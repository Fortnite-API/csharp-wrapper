using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrStatsV2V1StatsPlatform : IEquatable<BrStatsV2V1StatsPlatform>
	{
		[J] public BrStatsV2V1OverallStats Overall { get; private set; }
		[J] public BrStatsV2V1SoloStats Solo { get; private set; }
		[J] public BrStatsV2V1DuoStats Duo { get; private set; }
		[J] public BrStatsV2V1SquadStats Trio { get; private set; }
		[J] public BrStatsV2V1SquadStats Squad { get; private set; }
		[J] public BrStatsV2V1LtmStats Ltm { get; private set; }

		public bool Equals(BrStatsV2V1StatsPlatform other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Overall, other.Overall) && Equals(Solo, other.Solo) && Equals(Duo, other.Duo) && Equals(Trio, other.Trio) && Equals(Squad, other.Squad) && Equals(Ltm, other.Ltm);
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

			return Equals((BrStatsV2V1StatsPlatform)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Overall.GetHashCode();
				hashCode = hashCode * 397 ^ (Solo != null ? Solo.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Duo != null ? Duo.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Trio != null ? Trio.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Squad != null ? Squad.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Ltm != null ? Ltm.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrStatsV2V1StatsPlatform left, BrStatsV2V1StatsPlatform right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrStatsV2V1StatsPlatform left, BrStatsV2V1StatsPlatform right)
		{
			return !Equals(left, right);
		}
	}
}