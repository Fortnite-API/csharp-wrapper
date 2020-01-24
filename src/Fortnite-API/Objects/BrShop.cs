using System;
using System.Collections.Generic;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrShop : IEquatable<BrShop>
	{
		[J("hash")] public string Hash { get; private set; }
		[J("date")] public DateTime Date { get; private set; }
		[J("featured")] public List<BrShopEntry> Featured { get; private set; }
		[J("daily")] public List<BrShopEntry> Daily { get; private set; }
		[J("votes")] public List<BrShopEntry> Votes { get; private set; }
		[J("voteWinners")] public List<BrShopEntry> VoteWinners { get; private set; }

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

			return Hash == other.Hash && Date.Equals(other.Date);
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

			if (obj.GetType() != typeof(BrShop))
			{
				return false;
			}

			return Equals((BrShop)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Hash, Date);
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