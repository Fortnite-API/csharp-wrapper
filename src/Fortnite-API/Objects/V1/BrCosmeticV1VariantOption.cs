using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrCosmeticV1VariantOption : IEquatable<BrCosmeticV1VariantOption>
	{
		[J] public string Tag { get; private set; }
		[J] public string Name { get; private set; }
		[J] public ImageV1Data Image { get; private set; }

		public bool Equals(BrCosmeticV1VariantOption other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Tag == other.Tag && Name == other.Name && Equals(Image, other.Image);
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

			if (obj.GetType() != typeof(BrCosmeticV1VariantOption))
			{
				return false;
			}

			return Equals((BrCosmeticV1VariantOption)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Tag != null ? Tag.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Name != null ? Name.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Image != null ? Image.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrCosmeticV1VariantOption left, BrCosmeticV1VariantOption right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV1VariantOption left, BrCosmeticV1VariantOption right)
		{
			return !Equals(left, right);
		}
	}
}