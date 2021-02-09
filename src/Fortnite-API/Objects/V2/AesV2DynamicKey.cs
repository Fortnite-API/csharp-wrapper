using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(PakGuid) + "}")]
	public class AesV2DynamicKey : IEquatable<AesV2DynamicKey>
	{
		[J] public string PakFilename { get; private set; }
		[J] public string PakGuid { get; private set; }
		[J] public string Key { get; private set; }

		public bool Equals(AesV2DynamicKey other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return PakGuid == other.PakGuid && Key == other.Key;
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

			return Equals((AesV2DynamicKey)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return PakGuid.GetHashCode() * 397 ^ Key.GetHashCode();
			}
		}

		public static bool operator ==(AesV2DynamicKey left, AesV2DynamicKey right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(AesV2DynamicKey left, AesV2DynamicKey right)
		{
			return !Equals(left, right);
		}
	}
}