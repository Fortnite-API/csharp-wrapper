using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;
using I = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrShopV1 : IEquatable<BrShopV1>
	{
		[J] public string Hash { get; private set; }
		[J] public DateTime Date { get; private set; }
		[J] public List<BrShopV1Entry> Featured { get; private set; }
		[J] public List<BrShopV1Entry> Daily { get; private set; }
		[J] public List<BrShopV1Entry> Votes { get; private set; }
		[J] public List<BrShopV1Entry> VoteWinners { get; private set; }

		[I] public bool HasFeaturedEntries => Featured != null && Featured.Count > 0;
		[I] public bool HasDailyEntries => Daily != null && Daily.Count > 0;
		[I] public bool HasVoteEntries => Votes != null && Votes.Count > 0;
		[I] public bool HasVoteWinnerEntries => VoteWinners != null && VoteWinners.Count > 0;

		public bool Equals(BrShopV1 other)
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

			if (obj.GetType() != typeof(BrShopV1))
			{
				return false;
			}

			return Equals((BrShopV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Hash != null ? Hash.GetHashCode() : 0) * 397 ^ Date.GetHashCode();
			}
		}

		public static bool operator ==(BrShopV1 left, BrShopV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV1 left, BrShopV1 right)
		{
			return !Equals(left, right);
		}
	}
}