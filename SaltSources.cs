using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KeePassDiceware
{
	public class SaltSource : ICloneable
	{
		private const int DefaultSaltMinimumLength = 1;
		private const int DefaultSaltMaximumLength = 1;

		private const string AllUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private const string AllLower = "abcdefghijklmnopqrstuvwxyz";
		private const string AllDigits = "0123456789";

		// Copyright (C) 2014-2021 Mark McGuill. All rights reserved.
		private const string AllSymbols = "+-=_@#$%^&;:,.<>/~\\[](){}?!|*'\"";
		// Copyright (C) 2014-2021 Mark McGuill. All rights reserved.
		private const string Emojis = @"😀😃😄😁😆😅";
		// Copyright (C) 2014-2021 Mark McGuill. All rights reserved.
		private const string Latin1Supplement =
				"\u00A1\u00A2\u00A3\u00A4\u00A5\u00A6\u00A7" +
				"\u00A8\u00A9\u00AA\u00AB\u00AC\u00AE\u00AF" +
				"\u00B0\u00B1\u00B2\u00B3\u00B4\u00B5\u00B6\u00B7" +
				"\u00B8\u00B9\u00BA\u00BB\u00BC\u00BD\u00BE\u00BF" +
				"\u00C0\u00C1\u00C2\u00C3\u00C4\u00C5\u00C6\u00C7" +
				"\u00C8\u00C9\u00CA\u00CB\u00CC\u00CD\u00CE\u00CF" +
				"\u00D0\u00D1\u00D2\u00D3\u00D4\u00D5\u00D6\u00D7" +
				"\u00D8\u00D9\u00DA\u00DB\u00DC\u00DD\u00DE\u00DF" +
				"\u00E0\u00E1\u00E2\u00E3\u00E4\u00E5\u00E6\u00E7" +
				"\u00E8\u00E9\u00EA\u00EB\u00EC\u00ED\u00EE\u00EF" +
				"\u00F0\u00F1\u00F2\u00F3\u00F4\u00F5\u00F6\u00F7" +
				"\u00F8\u00F9\u00FA\u00FB\u00FC\u00FD\u00FE\u00FF";

		public string Name { get; set; }

		[Browsable(false)]
		public string Key => Name.Replace(" ", string.Empty);
		public string Pool { get; set; }
		public int MinimumAmount { get; set; }
		public int MaximumAmount { get; set; }
		public bool Enabled
		{
			get => (MinimumAmount > 0 || MaximumAmount > 0) && MaximumAmount >= MinimumAmount;
			set
			{
				if (Enabled == value)
				{
					return;
				}

				if (value)
				{
					MinimumAmount = DefaultSaltMinimumLength;
					MaximumAmount = DefaultSaltMaximumLength;
				}
				else
				{
					MinimumAmount = MaximumAmount = 0;
				}
			}
		}
		

		public SaltSource(string name, string pool, bool enabled = true)
		{
			Name = name;
			Pool = pool;

			Enabled = enabled;
		}

		public SaltSource()
		{
			Enabled = true;
		}

		public void Enable()
		{
			Enabled = true;
		}

		public void Disable()
		{
			Enabled = false;
		}

		public char[] GetCharacterPool()
		{
			return Pool.ToCharArray();
		}

		public object Clone() => MemberwiseClone();

		public static List<SaltSource> Default
		{
			get
			{
				List<SaltSource> defaultList = new();

				defaultList.Add(new SaltSource("Uppercase", AllUpper));
				defaultList.Add(new SaltSource("Lowercase", AllLower));
				defaultList.Add(new SaltSource("Digits", AllDigits));
				defaultList.Add(new SaltSource("Symbols", AllSymbols));
				defaultList.Add(new SaltSource("Emoji", Emojis, enabled: false));
				defaultList.Add(new SaltSource("Latin 1 Supplement", Latin1Supplement));

				return defaultList;
			}
		}

	}
}
