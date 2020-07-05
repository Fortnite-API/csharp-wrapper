using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrCosmeticV1Variant : IEquatable<BrCosmeticV1Variant>
	{
		[J] public string Channel { get; private set; }
		[J] public string Type { get; private set; }
		[J] public List<BrCosmeticV1VariantOption> Options { get; private set; }

		public bool TryGetVariantOption(string optionName, out BrCosmeticV1VariantOption outOption)
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

		public bool TryGetVariantOptionByTag(string optionTag, out BrCosmeticV1VariantOption outOption)
		{
			if (optionTag == null)
			{
				throw new ArgumentNullException(nameof(optionTag));
			}

			if (optionTag.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(optionTag));
			}

			foreach (var option in Options)
			{
				if (!string.Equals(option.Tag, optionTag, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}

				outOption = option;
				return true;
			}

			outOption = null;
			return false;
		}

		public bool Equals(BrCosmeticV1Variant other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Channel == other.Channel && Type == other.Type && Equals(Options, other.Options);
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

			if (obj.GetType() != typeof(BrCosmeticV1Variant))
			{
				return false;
			}

			return Equals((BrCosmeticV1Variant)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Channel != null ? Channel.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Type != null ? Type.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Options != null ? Options.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrCosmeticV1Variant left, BrCosmeticV1Variant right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV1Variant left, BrCosmeticV1Variant right)
		{
			return !Equals(left, right);
		}
	}
}