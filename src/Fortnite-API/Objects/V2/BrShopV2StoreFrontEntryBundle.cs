using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Name) + "}")]
	public class BrShopV2StoreFrontEntryBundle : IEquatable<BrShopV2StoreFrontEntryBundle>
	{
		[J] public string Name { get; private set; }
		[J] public string Info { get; private set; }
		[J] public Uri Image { get; private set; }

		public bool Equals(BrShopV2StoreFrontEntryBundle other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Name == other.Name && Info == other.Info && Equals(Image, other.Image);
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

			return Equals((BrShopV2StoreFrontEntryBundle)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Name != null ? Name.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Info != null ? Info.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Image != null ? Image.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrShopV2StoreFrontEntryBundle left, BrShopV2StoreFrontEntryBundle right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2StoreFrontEntryBundle left, BrShopV2StoreFrontEntryBundle right)
		{
			return !Equals(left, right);
		}
	}
}