using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class AesData : IEquatable<AesData>
	{
		[J("aes")] public string Aes { get; private set; }
		[J("build")] public string Build { get; private set; }
		[J("lastUpdate")] public DateTime LastUpdate { get; private set; }

		public bool Equals(AesData other)
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

			if (obj.GetType() != typeof(AesData))
			{
				return false;
			}

			return Equals((AesData)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Aes, Build, LastUpdate);
		}

		public static bool operator ==(AesData left, AesData right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(AesData left, AesData right)
		{
			return !Equals(left, right);
		}
	}
}