using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	[DebuggerDisplay("{" + nameof(Level) + "}")]
	public class BrStatsV2V1BattlePass : IEquatable<BrStatsV2V1BattlePass>
	{
		[J] public int Level { get; private set; }
		[J] public int Progress { get; private set; }

		public bool Equals(BrStatsV2V1BattlePass other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Level == other.Level && Progress == other.Progress;
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

			return Equals((BrStatsV2V1BattlePass)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Level * 397 ^ Progress;
			}
		}

		public static bool operator ==(BrStatsV2V1BattlePass left, BrStatsV2V1BattlePass right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrStatsV2V1BattlePass left, BrStatsV2V1BattlePass right)
		{
			return !Equals(left, right);
		}
	}
}