using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class NewsV1 : IEquatable<NewsV1>
	{
		[J] public string Language;
		[J] public string Title;
		[J] public DateTime LastModified;
		[J] public List<NewsV1Motd> Motds;
		[J] public List<NewsV1Message> Messages;

		public bool Equals(NewsV1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Language == other.Language && Title == other.Title && LastModified.Equals(other.LastModified);
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

			if (obj.GetType() != typeof(NewsV1))
			{
				return false;
			}

			return Equals((NewsV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Language != null ? Language.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Title != null ? Title.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ LastModified.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(NewsV1 left, NewsV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV1 left, NewsV1 right)
		{
			return !Equals(left, right);
		}
	}
}