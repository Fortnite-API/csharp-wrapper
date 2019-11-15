using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrCosmeticVariantOption : IEquatable<BrCosmeticVariantOption>
	{
		[J("name")] public string Name { get; private set; }
		[J("image")] public ApiImage Image { get; private set; }

		public bool Equals(BrCosmeticVariantOption other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Name == other.Name && Image.Equals(other.Image);
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

			if (obj is BrCosmeticVariantOption brCosmeticVariantOption)
			{
				return Equals(brCosmeticVariantOption);
			}

			return false;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Name.GetHashCode() * 397 ^ Image.GetHashCode();
			}
		}

		public static bool operator ==(BrCosmeticVariantOption left, BrCosmeticVariantOption right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticVariantOption left, BrCosmeticVariantOption right)
		{
			return !Equals(left, right);
		}
	}
}