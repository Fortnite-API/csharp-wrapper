using System;
using System.Collections.Generic;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	public class BrCosmeticV2Images : IEquatable<BrCosmeticV2Images>
	{
		[J] public Uri SmallIcon { get; private set; }
		[J] public Uri Icon { get; private set; }
		[J] public Uri Featured { get; private set; }
		[J] public Dictionary<string, Uri> Other { get; private set; }

		[I] public bool HasSmallIcon => SmallIcon != null;
		[I] public bool HasIcon => Icon != null;
		[I] public bool HasFeatured => Featured != null;
		[I] public bool HasOther => Other != null && Other.Count != 0;

		public Uri Get(bool useFeatured = true)
		{
			return useFeatured && HasFeatured ? Featured : Icon ?? SmallIcon;
		}

		public bool Equals(BrCosmeticV2Images other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return SmallIcon == other.SmallIcon && Icon == other.Icon && Featured == other.Featured && Equals(Other, other.Other);
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

			return Equals((BrCosmeticV2Images)obj);
		}

		public override int GetHashCode()
		{ 
			unchecked
			{
				var hashCode = SmallIcon != null ? SmallIcon.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Icon != null ? Icon.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Featured != null ? Featured.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Other != null ? Other.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrCosmeticV2Images left, BrCosmeticV2Images right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2Images left, BrCosmeticV2Images right)
		{
			return !Equals(left, right);
		}
	}
}