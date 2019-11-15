using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrCosmeticVariant : IEquatable<BrCosmeticVariant>
	{
		[J("type")] public string Type { get; private set; }
		[J("options")] public List<BrCosmeticVariantOption> Options { get; private set; }

		public bool TryGetVariantOption(string optionName, out BrCosmeticVariantOption outOption)
		{
			if (optionName == null)
			{
				throw new ArgumentNullException(nameof(optionName));
			}

			if (optionName.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(optionName));
			}

			foreach (var option in Options)
			{
				if (!string.Equals(option.Name, optionName, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}

				outOption = option;
				return true;
			}

			outOption = null;
			return false;
		}

		public bool Equals(BrCosmeticVariant other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Type == other.Type && Equals(Options, other.Options);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
			{
				return false;
			}

			if (ReferenceEquals(this, obj))
			{
				return true;
			}

			if (obj is BrCosmeticVariant brCosmeticVariant)
			{
				return Equals(brCosmeticVariant);
			}

			return false;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Type != null ? Type.GetHashCode() : 0) * 397 ^ (Options != null ? Options.GetHashCode() : 0);
			}
		}

		public static bool operator ==(BrCosmeticVariant left, BrCosmeticVariant right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticVariant left, BrCosmeticVariant right)
		{
			return !Equals(left, right);
		}
	}
}