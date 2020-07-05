using System;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class ImageV1Data : IEquatable<ImageV1Data>
	{
		[Obsolete("This property will always return null.")]
		[I] public string Hash { get; } = null;
		[J] public Uri Url { get; private set; }

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

			return Url.Equals(other.Url);
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

			return Equals((ImageV1Data)obj);
		}

		public override int GetHashCode()
		{
			return Url.GetHashCode();
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