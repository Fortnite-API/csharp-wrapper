using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class NewsMessage : IEquatable<NewsMessage>
	{
		[J("image")] public Uri ImageUrl { get; private set; }
		[J("hidden")] public bool Hidden { get; private set; }
		[J("messageType")] public string MessageType { get; private set; }
		[J("type")] public string Type { get; private set; }
		[J("adspace")] public string Adspace { get; private set; }
		[J("title")] public string Title { get; private set; }
		[J("body")] public string Body { get; private set; }
		[J("spotlight")] public bool Spotlight { get; private set; }

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

			if (obj.GetType() != typeof(NewsMessage))
			{
				return false;
			}

			return Equals((NewsMessage)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(ImageUrl, Hidden, MessageType, Type, Adspace, Title, Body, Spotlight);
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