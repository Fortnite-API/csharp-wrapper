using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Code) + "}")]
	public class CreatorCodeV2 : IEquatable<CreatorCodeV2>
	{
		[J] public string Code { get; private set; }
		[J] public AccountData Account { get; private set; }
		[J] public string Status { get; private set; }
		[J] public bool Verified { get; private set; }

		public bool Equals(CreatorCodeV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Code == other.Code && Account.Equals(other.Account) && Status == other.Status && Verified == other.Verified;
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

			return Equals((CreatorCodeV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Code.GetHashCode();
				hashCode = hashCode * 397 ^ Account.GetHashCode();
				hashCode = hashCode * 397 ^ Status.GetHashCode();
				hashCode = hashCode * 397 ^ Verified.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(CreatorCodeV2 left, CreatorCodeV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(CreatorCodeV2 left, CreatorCodeV2 right)
		{
			return !Equals(left, right);
		}
	}
}