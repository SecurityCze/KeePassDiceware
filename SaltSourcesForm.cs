using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

using KeePass.UI;

namespace KeePassDiceware
{
	public partial class SaltSourcesForm : Form
	{

		public List<SaltSource> Result;

		private BindingList<SaltSource> _saltSourcesBindingList;

		public SaltSourcesForm(List<SaltSource> initialSaltSources)
		{
			InitializeComponent();
			SaltSourceDataGridView.AutoGenerateColumns = false;
			SaltSourceDataGridView.AllowUserToAddRows = true;
			PopulateSaltSources(initialSaltSources);
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void LinkLabel_LinkClicked_OpenTagAsLink(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (sender is LinkLabel ll && ll.Tag is string url)
			{
				try
				{
					System.Diagnostics.Process.Start($"{url}?utm_source={nameof(KeePassDiceware)}");
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, $"Failed to open URL: {url}\n\n{ex.Message}", "Link Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void PopulateSaltSources(List<SaltSource> initialSaltSources)
		{
			List<SaltSource> renderableSaltSources = initialSaltSources.Where(ss => ss.CanRender).ToList();
			Result = renderableSaltSources.ConvertAll(ss => (SaltSource)ss.Clone());

			int removed = initialSaltSources.Count - Result.Count;
			if (removed > 0)
			{
				string removedS = removed == 1 ? string.Empty : "s";
				string removedHelpingVerb = removed == 1 ? "was" : "were";
				string removedPronoun = removed == 1 ? "it is" : "they are";
				MessageBox.Show(this, $"{removed} salt source{removedS} {removedHelpingVerb} removed because {removedPronoun} not supported by the current runtime.",
					$"Unsupported Source{removedS} Removed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			_saltSourcesBindingList = new(Result);

			SaltSourceDataGridView.DataSource = _saltSourcesBindingList;
		}

		private void RestoreDefaultsButton_Click(object sender, EventArgs e)
		{
			PopulateSaltSources(SaltSource.RuntimeCanHandleEmoji
				? SaltSource.DefaultSources
				: SaltSource.DefaultSourcesWithoutEmoji
			);
		}

		private void SaltSourceDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			DataGridViewRow row = SaltSourceDataGridView.Rows[e.RowIndex];

			if (row.DataBoundItem is SaltSource ss)
			{
				if (Result.Count(oss => oss.Key == ss.Key) >= 2)
				{
					row.ErrorText = "This source's name is too similar to another source. Please make it more unique.";
					e.Cancel = true;
				}
			}
		}

		private void SaltSourceDataGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = SaltSourceDataGridView.Rows[e.RowIndex];
			row.ErrorText = string.Empty;

		}
	}
}
