using System;
using System.Collections.Generic;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Build) + "}")]
	public class AesV2 : IEquatable<AesV2>
	{
		[J] public string Build { get; private set; }
		[J] public string MainKey { get; private set; }
		[J] public List<AesV2DynamicKey> DynamicKeys { get; private set; }
		[J] public DateTime Updated { get; private set; }

		public bool HasDynamicKeys => DynamicKeys != null;

		public bool Equals(AesV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Build == other.Build && MainKey == other.MainKey && DynamicKeys.Equals(other.DynamicKeys) && Updated.Equals(other.Updated);
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

			return Equals((AesV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Build.GetHashCode();
				hashCode = hashCode * 397 ^ MainKey.GetHashCode();
				hashCode = hashCode * 397 ^ DynamicKeys.GetHashCode();
				hashCode = hashCode * 397 ^ Updated.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(AesV2 left, AesV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(AesV2 left, AesV2 right)
		{
			return !Equals(left, right);
		}
	}
}