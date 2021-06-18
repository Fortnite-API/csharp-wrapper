using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Name) + "}")]
	public class BrShopV2StoreFrontEntrySection : IEquatable<BrShopV2StoreFrontEntrySection>
	{
		[J] public string Id { get; private set; }
		[J] public string Name { get; private set; }
		[J] public int Index { get; private set; }
		[J] public int LandingPriority { get; private set; }
		[J] public bool SortOffersByOwnership { get; private set; }
		[J] public bool ShowIneligibleOffers { get; private set; }
		[J] public bool ShowIneligibleOffersIfGiftable { get; private set; }
		[J] public bool ShowTimer { get; private set; }
		[J] public bool EnableToastNotification { get; private set; }
		[J] public bool Hidden { get; private set; }

		public bool Equals(BrShopV2StoreFrontEntrySection other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Name == other.Name && Index == other.Index && LandingPriority == other.LandingPriority && SortOffersByOwnership == other.SortOffersByOwnership && ShowIneligibleOffers == other.ShowIneligibleOffers && ShowIneligibleOffersIfGiftable == other.ShowIneligibleOffersIfGiftable && ShowTimer == other.ShowTimer && EnableToastNotification == other.EnableToastNotification && Hidden == other.Hidden;
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

			return Equals((BrShopV2StoreFrontEntrySection)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id != null ? Id.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Name != null ? Name.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Index;
				hashCode = hashCode * 397 ^ LandingPriority;
				hashCode = hashCode * 397 ^ SortOffersByOwnership.GetHashCode();
				hashCode = hashCode * 397 ^ ShowIneligibleOffers.GetHashCode();
				hashCode = hashCode * 397 ^ ShowIneligibleOffersIfGiftable.GetHashCode();
				hashCode = hashCode * 397 ^ ShowTimer.GetHashCode();
				hashCode = hashCode * 397 ^ EnableToastNotification.GetHashCode();
				hashCode = hashCode * 397 ^ Hidden.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(BrShopV2StoreFrontEntrySection left, BrShopV2StoreFrontEntrySection right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2StoreFrontEntrySection left, BrShopV2StoreFrontEntrySection right)
		{
			return !Equals(left, right);
		}
	}
}