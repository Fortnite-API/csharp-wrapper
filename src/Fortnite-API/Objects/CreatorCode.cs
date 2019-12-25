using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class CreatorCode : IEquatable<CreatorCode>
	{
		[J("id")] public string Id { get; private set; }
		[J("slug")] public string Slug { get; private set; }
		[J("displayName")] public string DisplayName { get; private set; }
		[J("status")] public string Status { get; private set; }
		[J("verified")] public bool Verified { get; private set; }

		public bool Equals(CreatorCode other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Slug == other.Slug && DisplayName == other.DisplayName && Status == other.Status && Verified == other.Verified;
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

			if (obj.GetType() != typeof(CreatorCode))
			{
				return false;
			}

			return Equals((CreatorCode)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Slug, DisplayName, Status, Verified);
		}

		public static bool operator ==(CreatorCode left, CreatorCode right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(CreatorCode left, CreatorCode right)
		{
			return !Equals(left, right);
		}
	}
}