using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class CombinedNewsV1 : IEquatable<CombinedNewsV1>
	{
		[J] public NewsV1 Br { get; private set; }
		[J] public NewsV1 Stw { get; private set; }
		[J] public NewsV1 Creative { get; private set; }

		public bool Equals(CombinedNewsV1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Br, other.Br) && Equals(Stw, other.Stw) && Equals(Creative, other.Creative);
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

			if (obj.GetType() != typeof(CombinedNewsV1))
			{
				return false;
			}

			return Equals((CombinedNewsV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Br != null ? Br.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Stw != null ? Stw.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Creative != null ? Creative.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(CombinedNewsV1 left, CombinedNewsV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(CombinedNewsV1 left, CombinedNewsV1 right)
		{
			return !Equals(left, right);
		}
	}
}