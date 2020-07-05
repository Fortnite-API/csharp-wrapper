using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	[DebuggerDisplay("{" + nameof(Name) + "}")]
	public class AccountData : IEquatable<AccountData>
	{
		[J] public string Id { get; set; }
		[J] public string Name { get; set; }

		public bool Equals(AccountData other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Name == other.Name;
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

			return Equals((AccountData)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Id.GetHashCode() * 397 ^ Name.GetHashCode();
			}
		}

		public static bool operator ==(AccountData left, AccountData right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(AccountData left, AccountData right)
		{
			return !Equals(left, right);
		}
	}
}
