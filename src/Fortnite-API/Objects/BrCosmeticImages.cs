using System;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrCosmeticImages : IEquatable<BrCosmeticImages>
	{
		[J("smallIcon")] public ApiImage SmallIcon { get; private set; }
		[J("icon")] public ApiImage Icon { get; private set; }
		[J("featured")] public ApiImage Featured { get; private set; }
		[J("background")] public ApiImage Background { get; private set; }
		[J("coverArt")] public ApiImage CoverArt { get; private set; }
		[J("decal")] public ApiImage Decal { get; private set; }

		[I]public bool HasSmallIcon => SmallIcon != null;
		[I]public bool HasIcon => Icon != null;
		[I]public bool HasFeatured => Featured != null;
		[I]public bool HasBackground => Background != null;
		[I]public bool HasCoverArt => CoverArt != null;
		[I]public bool HasDecal => Decal != null;

		public bool Equals(BrCosmeticImages other)
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

			if (obj.GetType() != typeof(BrCosmeticImages))
			{
				return false;
			}

			return Equals((BrCosmeticImages)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(SmallIcon, Icon, Featured, Background, CoverArt, Decal);
		}

		public static bool operator ==(BrCosmeticImages left, BrCosmeticImages right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticImages left, BrCosmeticImages right)
		{
			return !Equals(left, right);
		}
	}
}