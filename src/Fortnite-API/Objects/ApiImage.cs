using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class ApiImage : IEquatable<ApiImage>
	{
		[J("hash")] public string Hash { get; private set; }
		[J("url")] public Uri Url { get; private set; }

		public bool Equals(ApiImage other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Hash == other.Hash && Equals(Url, other.Url);
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

			if (obj.GetType() != typeof(ApiImage))
			{
				return false;
			}

			return Equals((ApiImage)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Hash, Url);
		}

		public static bool operator ==(ApiImage left, ApiImage right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(ApiImage left, ApiImage right)
		{
			return !Equals(left, right);
		}
	}
}