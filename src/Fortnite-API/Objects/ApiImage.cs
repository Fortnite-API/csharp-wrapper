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

			return Hash == other.Hash && Url.Equals(other.Url);
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

			if (obj is ApiImage apiImage)
			{
				return Equals(apiImage);
			}

			return false;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Hash.GetHashCode() * 397 ^ Url.GetHashCode();
			}
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