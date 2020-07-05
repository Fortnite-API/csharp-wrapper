using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	[DebuggerDisplay("{" + nameof(Score) + "}")]
	public class BrStatsV2V1DuoStats : IEquatable<BrStatsV2V1DuoStats>
	{
		[J] public long Score { get; private set; }
		[J] public double ScorePerMin { get; private set; }
		[J] public double ScorePerMatch { get; private set; }
		[J] public long Wins { get; private set; }
		[J] public long Top5 { get; private set; }
		[J] public long Top12 { get; private set; }
		[J] public long Kills { get; private set; }
		[J] public double KillsPerMin { get; private set; }
		[J] public double KillsPerMatch { get; private set; }
		[J] public long Deaths { get; private set; }
		[J] public double Kd { get; private set; }
		[J] public long Matches { get; private set; }
		[J] public double WinRate { get; private set; }
		[J] public long MinutesPlayed { get; private set; }
		[J] public long PlayersOutlived { get; private set; }
		[J] public DateTime LastModified { get; private set; }

		public bool Equals(BrStatsV2V1DuoStats other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Score == other.Score && Wins == other.Wins && Kills == other.Kills && Matches == other.Matches && LastModified.Equals(other.LastModified);
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

			return Equals((BrStatsV2V1DuoStats)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Score.GetHashCode();
				hashCode = hashCode * 397 ^ Wins.GetHashCode();
				hashCode = hashCode * 397 ^ Kills.GetHashCode();
				hashCode = hashCode * 397 ^ Matches.GetHashCode();
				hashCode = hashCode * 397 ^ LastModified.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(BrStatsV2V1DuoStats left, BrStatsV2V1DuoStats right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrStatsV2V1DuoStats left, BrStatsV2V1DuoStats right)
		{
			return !Equals(left, right);
		}
	}
}