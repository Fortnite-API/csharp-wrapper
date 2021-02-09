using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;
using I = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrCosmeticV1Images : IEquatable<BrCosmeticV1Images>
	{
		[J] public ImageV1Data SmallIcon { get; private set; }
		[J] public ImageV1Data Icon { get; private set; }
		[J] public ImageV1Data Featured { get; private set; }
		[J] public ImageV1Data Background { get; private set; }
		[J] public ImageV1Data CoverArt { get; private set; }
		[J] public ImageV1Data Decal { get; private set; }

		[I] public bool HasSmallIcon => SmallIcon != null;
		[I] public bool HasIcon => Icon != null;
		[I] public bool HasFeatured => Featured != null;
		[I] public bool HasBackground => Background != null;
		[I] public bool HasCoverArt => CoverArt != null;
		[I] public bool HasDecal => Decal != null;

		public bool Equals(BrCosmeticV1Images other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(SmallIcon, other.SmallIcon) && Equals(Icon, other.Icon) && Equals(Featured, other.Featured) && Equals(Background, other.Background) && Equals(CoverArt, other.CoverArt) && Equals(Decal, other.Decal);
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

			if (obj.GetType() != typeof(BrCosmeticV1Images))
			{
				return false;
			}

			return Equals((BrCosmeticV1Images)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = SmallIcon != null ? SmallIcon.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Icon != null ? Icon.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Featured != null ? Featured.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Background != null ? Background.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (CoverArt != null ? CoverArt.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Decal != null ? Decal.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrCosmeticV1Images left, BrCosmeticV1Images right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV1Images left, BrCosmeticV1Images right)
		{
			return !Equals(left, right);
		}
	}
}