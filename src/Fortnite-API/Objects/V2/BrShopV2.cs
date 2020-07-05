using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Date) + "}")]
	public class BrShopV2 : IEquatable<BrShopV2>
	{
		[J] public string Hash { get; private set; }
		[J] public DateTime Date { get; private set; }
		[J] public BrShopV2StoreFront Featured { get; private set; }
		[J] public BrShopV2StoreFront Daily { get; private set; }
		[J] public BrShopV2StoreFront SpecialFeatured { get; private set; }
		[J] public BrShopV2StoreFront SpecialDaily { get; private set; }
		[J] public BrShopV2StoreFront Votes { get; private set; }
		[J] public BrShopV2StoreFront VoteWinners { get; private set; }

		public bool HasFeatured => Featured != null;
		public bool HasDaily => Daily != null;
		public bool HasSpecialFeatured => SpecialFeatured != null;
		public bool HasSpecialDaily => SpecialDaily != null;
		public bool HasVotes => Votes != null;
		public bool HasVoteWinners => VoteWinners != null;

		public bool Equals(BrShopV2 other)
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

			return Equals((BrShopV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Hash.GetHashCode() * 397 ^ Date.GetHashCode();
			}
		}

		public static bool operator ==(BrShopV2 left, BrShopV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2 left, BrShopV2 right)
		{
			return !Equals(left, right);
		}
	}
}