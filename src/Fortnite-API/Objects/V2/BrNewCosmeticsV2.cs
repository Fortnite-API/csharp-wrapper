using System;
using System.Collections.Generic;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Hash) + "}")]
	public class BrNewCosmeticsV2 : IEquatable<BrNewCosmeticsV2>
	{
		[J] public string Build { get; private set; }
		[J] public string PreviousBuild { get; private set; }
		[J] public string Hash { get; private set; }
		[J] public DateTime Date { get; private set; }
		[J] public DateTime LastAddition { get; private set; }
		[J] public List<BrCosmeticV2> Items { get; private set; }

		public bool Equals(BrNewCosmeticsV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Build == other.Build && PreviousBuild == other.PreviousBuild && Hash == other.Hash && Date.Equals(other.Date) && LastAddition.Equals(other.LastAddition);
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

			return Equals((BrNewCosmeticsV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Build.GetHashCode();
				hashCode = hashCode * 397 ^ PreviousBuild.GetHashCode();
				hashCode = hashCode * 397 ^ Hash.GetHashCode();
				hashCode = hashCode * 397 ^ Date.GetHashCode();
				hashCode = hashCode * 397 ^ LastAddition.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(BrNewCosmeticsV2 left, BrNewCosmeticsV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrNewCosmeticsV2 left, BrNewCosmeticsV2 right)
		{
			return !Equals(left, right);
		}
	}
}