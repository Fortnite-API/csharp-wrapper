using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class News : IEquatable<News>
	{
		[J("language")] public string Language;
		[J("title")] public string Title;
		[J("lastModified")] public DateTime LastModified;
		[J("messages")] public List<NewsMessage> Messages;

		public bool Equals(News other)
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

			if (obj is News news)
			{
				return Equals(news);
			}

			return false;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Language.GetHashCode();
				hashCode = hashCode * 397 ^ Title.GetHashCode();
				hashCode = hashCode * 397 ^ LastModified.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(News left, News right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(News left, News right)
		{
			return !Equals(left, right);
		}
	}
}