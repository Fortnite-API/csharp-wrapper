using System;
using System.Collections.Generic;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(DevName) + "}")]
	public class BrShopV2StoreFrontEntry : IEquatable<BrShopV2StoreFrontEntry>
	{
		[J] public int RegularPrice { get; private set; }
		[J] public int FinalPrice { get; private set; }
		[J] public BrShopV2StoreFrontEntryBundle Bundle { get; private set; }
		[J] public BrShopV2StoreFrontEntryBanner Banner { get; private set; }
		[J] public bool Giftable { get; private set; }
		[J] public bool Refundable { get; private set; }
		[J] public int SortPriority { get; private set; }
		[J] public List<string> Categories { get; private set; }
		[J] public string SectionId { get; private set; }
		[J] public BrShopV2StoreFrontEntrySection Section { get; private set; }
		[J] public string DevName { get; private set; }
		[J] public string OfferId { get; private set; }
		[J] public string DisplayAssetPath { get; private set; }
		[J] public string TileSize { get; private set; }
		[J] public string NewDisplayAssetPath { get; private set; }
		[J] public BrNewDisplayAssetV2 NewDisplayAsset { get; private set; }
		[J] public List<BrCosmeticV2> Items { get; private set; }

		[I] public bool IsBundle => Bundle != null;
		[I] public bool HasBanner => Banner != null;
		[I] public bool HasCategories => Categories != null && Categories.Count != 0;
		[I] public bool HasSectionId => SectionId != null;
		[I] public bool IsDiscounted => FinalPrice < RegularPrice;
		[I] public bool HasDisplayAssetPath => DisplayAssetPath != null;
		[I] public bool HasNewDisplayAssetPath => NewDisplayAssetPath != null;

		public bool Equals(BrShopV2StoreFrontEntry other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return DevName == other.DevName && OfferId == other.OfferId;
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

			return Equals((BrShopV2StoreFrontEntry)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return DevName.GetHashCode() * 397 ^ OfferId.GetHashCode();
			}
		}

		public static bool operator ==(BrShopV2StoreFrontEntry left, BrShopV2StoreFrontEntry right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2StoreFrontEntry left, BrShopV2StoreFrontEntry right)
		{
			return !Equals(left, right);
		}
	}
}