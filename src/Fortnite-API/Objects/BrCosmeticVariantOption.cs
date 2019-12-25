using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrCosmeticVariantOption : IEquatable<BrCosmeticVariantOption>
	{
		[J("tag")] public string Tag { get; private set; }
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

			if (obj.GetType() != typeof(BrCosmeticVariantOption))
			{
				return false;
			}

			return Equals((BrCosmeticVariantOption)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Tag, Name, Image);
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