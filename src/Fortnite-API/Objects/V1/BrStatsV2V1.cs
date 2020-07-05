using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	[DebuggerDisplay("{" + nameof(Account) + "}")]
	public class BrStatsV2V1 : IEquatable<BrStatsV2V1>
	{
		[J] public AccountData Account { get; private set; }
		[J] public BrStatsV2V1BattlePass BattlePass { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public BrStatsV2V1Stats Stats { get; private set; }

		public bool Equals(BrStatsV2V1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Account.Equals(other.Account) && BattlePass.Equals(other.BattlePass) && Stats.Equals(other.Stats);
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

			if (obj.GetType() != this.GetType())
			{
				return false;
			}

			return Equals((BrStatsV2V1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Account.GetHashCode();
				hashCode = hashCode * 397 ^ BattlePass.GetHashCode();
				hashCode = hashCode * 397 ^ Stats.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(BrStatsV2V1 left, BrStatsV2V1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrStatsV2V1 left, BrStatsV2V1 right)
		{
			return !Equals(left, right);
		}
	}
}