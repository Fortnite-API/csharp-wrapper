using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class ImageV1Data : IEquatable<ImageV1Data>
	{
		[J("hash")] public string Hash { get; private set; }
		[J("url")] public Uri Url { get; private set; }

		public bool Equals(ImageV1Data other)
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

			if (obj.GetType() != typeof(ImageV1Data))
			{
				return false;
			}

			return Equals((ImageV1Data)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Hash != null ? Hash.GetHashCode() : 0) * 397 ^ (Url != null ? Url.GetHashCode() : 0);
			}
		}

		public static bool operator ==(ImageV1Data left, ImageV1Data right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(ImageV1Data left, ImageV1Data right)
		{
			return !Equals(left, right);
		}
	}
}