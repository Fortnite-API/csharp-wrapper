using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Tag) + "}")]
	public class BrCosmeticV2VariantOption : IEquatable<BrCosmeticV2VariantOption>
	{
		[J] public string Tag { get; private set; }
		[J] public string Name { get; private set; }
		[J] public string UnlockRequirements { get; private set; }
		[J] public Uri Image { get; private set; }

		public bool Equals(BrCosmeticV2VariantOption other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Tag == other.Tag;
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

			if (obj.GetType() != GetType())
			{
				return false;
			}

			return Equals((BrCosmeticV2VariantOption)obj);
		}

		public override int GetHashCode()
		{
			return Tag.GetHashCode();
		}

		public static bool operator ==(BrCosmeticV2VariantOption left, BrCosmeticV2VariantOption right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2VariantOption left, BrCosmeticV2VariantOption right)
		{
			return !Equals(left, right);
		}
	}
}