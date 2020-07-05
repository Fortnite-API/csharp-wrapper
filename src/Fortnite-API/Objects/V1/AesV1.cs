using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class AesV1 : IEquatable<AesV1>
	{
		[J] public string Aes { get; private set; }
		[J] public string Build { get; private set; }
		[J] public DateTime LastUpdate { get; private set; }

		public bool Equals(AesV1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Aes == other.Aes && Build == other.Build && LastUpdate.Equals(other.LastUpdate);
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

			if (obj.GetType() != typeof(AesV1))
			{
				return false;
			}

			return Equals((AesV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Aes != null ? Aes.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Build != null ? Build.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ LastUpdate.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(AesV1 left, AesV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(AesV1 left, AesV1 right)
		{
			return !Equals(left, right);
		}
	}
}