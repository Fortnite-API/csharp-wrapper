using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class CreatorCodeV1 : IEquatable<CreatorCodeV1>
	{
		[J] public string Id { get; private set; }
		[J] public string Slug { get; private set; }
		[J] public string DisplayName { get; private set; }
		[J] public string Status { get; private set; }
		[J] public bool Verified { get; private set; }

		public bool Equals(CreatorCodeV1 other)
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

			if (obj.GetType() != typeof(CreatorCodeV1))
			{
				return false;
			}

			return Equals((CreatorCodeV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id != null ? Id.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Slug != null ? Slug.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (DisplayName != null ? DisplayName.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Status != null ? Status.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Verified.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(CreatorCodeV1 left, CreatorCodeV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(CreatorCodeV1 left, CreatorCodeV1 right)
		{
			return !Equals(left, right);
		}
	}
}