using System.Windows.Forms;

namespace KeePassDiceware
{
	public partial class SaltSourcesForm
	{
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SaltSourceDataGridView = new System.Windows.Forms.DataGridView();
            this.saltSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RestoreDefaultsButton = new System.Windows.Forms.Button();
            this.saltSourceEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saltSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltSourceMinimumAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltSourceMaximumAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltSourcePool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltSourceCanRender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SaltSourceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(740, 444);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(861, 444);
            this.okButton.Margin = new System.Windows.Forms.Padding(4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SaltSourceDataGridView
            // 
            this.SaltSourceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaltSourceDataGridView.AutoGenerateColumns = false;
            this.SaltSourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaltSourceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saltSourceEnabled,
            this.saltSourceName,
            this.saltSourceMinimumAmount,
            this.saltSourceMaximumAmount,
            this.saltSourcePool,
            this.saltSourceCanRender});
            this.SaltSourceDataGridView.DataSource = this.saltSourceBindingSource;
            this.SaltSourceDataGridView.Location = new System.Drawing.Point(18, 18);
            this.SaltSourceDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SaltSourceDataGridView.Name = "SaltSourceDataGridView";
            this.SaltSourceDataGridView.RowHeadersWidth = 62;
            this.SaltSourceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SaltSourceDataGridView.Size = new System.Drawing.Size(956, 417);
            this.SaltSourceDataGridView.TabIndex = 3;
            this.SaltSourceDataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaltSourceDataGridView_RowValidated);
            this.SaltSourceDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SaltSourceDataGridView_RowValidating);
            // 
            // saltSourceBindingSource
            // 
            this.saltSourceBindingSource.DataSource = typeof(KeePassDiceware.SaltSource);
            // 
            // RestoreDefaultsButton
            // 
            this.RestoreDefaultsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RestoreDefaultsButton.CausesValidation = false;
            this.RestoreDefaultsButton.Location = new System.Drawing.Point(18, 444);
            this.RestoreDefaultsButton.Margin = new System.Windows.Forms.Padding(4);
            this.RestoreDefaultsButton.Name = "RestoreDefaultsButton";
            this.RestoreDefaultsButton.Size = new System.Drawing.Size(212, 34);
            this.RestoreDefaultsButton.TabIndex = 4;
            this.RestoreDefaultsButton.Text = "Restore &Defaults";
            this.RestoreDefaultsButton.UseVisualStyleBackColor = true;
            this.RestoreDefaultsButton.Click += new System.EventHandler(this.RestoreDefaultsButton_Click);
            // 
            // saltSourceEnabled
            // 
            this.saltSourceEnabled.DataPropertyName = "Enabled";
            this.saltSourceEnabled.HeaderText = "Enabled";
            this.saltSourceEnabled.MinimumWidth = 75;
            this.saltSourceEnabled.Name = "saltSourceEnabled";
            this.saltSourceEnabled.Width = 75;
            // 
            // saltSourceName
            // 
            this.saltSourceName.DataPropertyName = "Name";
            this.saltSourceName.FillWeight = 30F;
            this.saltSourceName.HeaderText = "Name";
            this.saltSourceName.MinimumWidth = 80;
            this.saltSourceName.Name = "saltSourceName";
            this.saltSourceName.Width = 200;
            // 
            // saltSourceMinimumAmount
            // 
            this.saltSourceMinimumAmount.DataPropertyName = "MinimumAmount";
            this.saltSourceMinimumAmount.HeaderText = "Minimum";
            this.saltSourceMinimumAmount.MinimumWidth = 30;
            this.saltSourceMinimumAmount.Name = "saltSourceMinimumAmount";
            this.saltSourceMinimumAmount.Width = 85;
            // 
            // saltSourceMaximumAmount
            // 
            this.saltSourceMaximumAmount.DataPropertyName = "MaximumAmount";
            this.saltSourceMaximumAmount.HeaderText = "Maximum";
            this.saltSourceMaximumAmount.MinimumWidth = 30;
            this.saltSourceMaximumAmount.Name = "saltSourceMaximumAmount";
            this.saltSourceMaximumAmount.Width = 85;
            // 
            // saltSourcePool
            // 
            this.saltSourcePool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.saltSourcePool.DataPropertyName = "Pool";
            this.saltSourcePool.HeaderText = "Characters in Source";
            this.saltSourcePool.MinimumWidth = 50;
            this.saltSourcePool.Name = "saltSourcePool";
            // 
            // saltSourceCanRender
            // 
            this.saltSourceCanRender.DataPropertyName = "CanRender";
            this.saltSourceCanRender.HeaderText = "CanRender";
            this.saltSourceCanRender.MinimumWidth = 8;
            this.saltSourceCanRender.Name = "saltSourceCanRender";
            this.saltSourceCanRender.ReadOnly = true;
            this.saltSourceCanRender.Visible = false;
            this.saltSourceCanRender.Width = 150;
            // 
            // SaltSourcesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(992, 496);
            this.Controls.Add(this.RestoreDefaultsButton);
            this.Controls.Add(this.SaltSourceDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "SaltSourcesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salt Sources";
            ((System.ComponentModel.ISupportInitialize)(this.SaltSourceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saltSourceBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		private Button cancelButton;
		private Button okButton;
		private DataGridView SaltSourceDataGridView;
		private Button RestoreDefaultsButton;
		private BindingSource saltSourceBindingSource;
		private System.ComponentModel.IContainer components;
		private DataGridViewCheckBoxColumn saltSourceEnabled;
		private DataGridViewTextBoxColumn saltSourceName;
		private DataGridViewTextBoxColumn saltSourceMinimumAmount;
		private DataGridViewTextBoxColumn saltSourceMaximumAmount;
		private DataGridViewTextBoxColumn saltSourcePool;
		private DataGridViewCheckBoxColumn saltSourceCanRender;
	}
}
