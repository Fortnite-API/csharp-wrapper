using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	public class NewsV2Combined : IEquatable<NewsV2Combined>
	{
		[J] public NewsV2 Br { get; private set; }
		[J] public NewsV2 Stw { get; private set; }
		[J] public NewsV2 Creative { get; private set; }

		public bool Equals(NewsV2Combined other)
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

			if (obj.GetType() != GetType())
			{
				return false;
			}

			return Equals((NewsV2Combined)obj);
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

		public static bool operator ==(NewsV2Combined left, NewsV2Combined right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV2Combined left, NewsV2Combined right)
		{
			return !Equals(left, right);
		}
	}
}