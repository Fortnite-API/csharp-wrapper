using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class NewsV1Message : IEquatable<NewsV1Message>
	{
		[J] public Uri Image { get; private set; }
		[J] public bool Hidden { get; private set; }
		[J] public string MessageType { get; private set; }
		[J] public string Type { get; private set; }
		[J] public string Adspace { get; private set; }
		[J] public string Title { get; private set; }
		[J] public string Body { get; private set; }
		[J] public bool Spotlight { get; private set; }

		public bool Equals(NewsV1Message other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Image, other.Image) && Hidden == other.Hidden && MessageType == other.MessageType && Type == other.Type && Adspace == other.Adspace && Title == other.Title && Body == other.Body && Spotlight == other.Spotlight;
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

			if (obj.GetType() != typeof(NewsV1Message))
			{
				return false;
			}

			return Equals((NewsV1Message)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Image != null ? Image.GetHashCode() : 0;
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

		public static bool operator ==(NewsV1Message left, NewsV1Message right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV1Message left, NewsV1Message right)
		{
			return !Equals(left, right);
		}
	}
}