using System;
using System.Collections.Generic;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrShop : IEquatable<BrShop>
	{
		[J("hash")] public string Hash;
		[J("date")] public DateTime Date;
		[J("featured")] public List<BrShopEntry> Featured;
		[J("daily")] public List<BrShopEntry> Daily;
		[J("votes")] public List<BrShopEntry> Votes;
		[J("voteWinners")] public List<BrShopEntry> VoteWinners;

		[I]public bool HasFeaturedEntries => Featured != null && Featured.Count > 0;
		[I]public bool HasDailyEntries => Daily != null && Daily.Count > 0;
		[I]public bool HasVoteEntries => Votes != null && Votes.Count > 0;
		[I]public bool HasVoteWinnerEntries => VoteWinners != null && VoteWinners.Count > 0;

		public bool Equals(BrShop other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Hash == other.Hash;
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

			if (obj is BrShop brShop)
			{
				return Equals(brShop);
			}

			return false;
		}

		public override int GetHashCode()
		{
			return Hash.GetHashCode();
		}

		public static bool operator ==(BrShop left, BrShop right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShop left, BrShop right)
		{
			return !Equals(left, right);
		}
	}
}