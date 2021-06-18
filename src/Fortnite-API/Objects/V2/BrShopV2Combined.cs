using System;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Date) + "}")]
	public class BrShopV2Combined : IEquatable<BrShopV2Combined>
	{
		[J] public string Hash { get; private set; }
		[J] public DateTime Date { get; private set; }
		[J] public Uri VBuckIcon { get; private set; }
		[J] public BrShopV2StoreFront Featured { get; private set; }
		[J] public BrShopV2StoreFront Daily { get; private set; }
		[J] public BrShopV2StoreFront Votes { get; private set; }
		[J] public BrShopV2StoreFront VoteWinners { get; private set; }

		[I] public bool HasFeatured => Featured != null;
		[I] public bool HasDaily => Daily != null;
		[I] public bool HasVotes => Votes != null;
		[I] public bool HasVoteWinners => VoteWinners != null;

		public bool Equals(BrShopV2Combined other)
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

			if (obj.GetType() != GetType())
			{
				return false;
			}

			return Equals((BrShopV2Combined)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Hash.GetHashCode() * 397 ^ Date.GetHashCode();
			}
		}

		public static bool operator ==(BrShopV2Combined left, BrShopV2Combined right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2Combined left, BrShopV2Combined right)
		{
			return !Equals(left, right);
		}
	}
}