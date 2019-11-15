using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class NewsMessage : IEquatable<NewsMessage>
	{
		[J("image")] public Uri ImageUrl;
		[J("hidden")] public bool Hidden;
		[J("messageType")] public string MessageType;
		[J("type")] public string Type;
		[J("adspace")] public string Adspace;
		[J("title")] public string Title;
		[J("body")] public string Body;
		[J("spotlight")] public bool Spotlight;

		public bool Equals(NewsMessage other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(ImageUrl, other.ImageUrl) && Hidden == other.Hidden && MessageType == other.MessageType && Type == other.Type && Adspace == other.Adspace && Title == other.Title && Body == other.Body && Spotlight == other.Spotlight;
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

			if (obj is NewsMessage newsMessage)
			{
				return Equals(newsMessage);
			}

			return false;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = ImageUrl != null ? ImageUrl.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ Hidden.GetHashCode();
				hashCode = hashCode * 397 ^ (MessageType != null ? MessageType.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Type != null ? Type.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Adspace != null ? Adspace.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Title != null ? Title.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Body != null ? Body.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Spotlight.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(NewsMessage left, NewsMessage right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsMessage left, NewsMessage right)
		{
			return !Equals(left, right);
		}
	}
}