using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class NewsV1Motd : IEquatable<NewsV1Motd>
	{
		[J] public string Id { get; private set; }
		[J] public string Title { get; private set; }
		[J] public string Body { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public Uri TileImage { get; private set; }
		[J] public bool Hidden { get; private set; }
		[J] public bool Spotlight { get; private set; }
		[J] public string Type { get; private set; }
		[J] public string EntryType { get; private set; }

		public bool Equals(NewsV1Motd other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Title == other.Title && Body == other.Body && Equals(Image, other.Image) && Equals(TileImage, other.TileImage) && Hidden == other.Hidden && Spotlight == other.Spotlight && Type == other.Type && EntryType == other.EntryType;
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

			if (obj.GetType() != typeof(NewsV1Motd))
			{
				return false;
			}

			return Equals((NewsV1Motd)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id != null ? Id.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Title != null ? Title.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Body != null ? Body.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Image != null ? Image.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (TileImage != null ? TileImage.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Hidden.GetHashCode();
				hashCode = hashCode * 397 ^ Spotlight.GetHashCode();
				hashCode = hashCode * 397 ^ (Type != null ? Type.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (EntryType != null ? EntryType.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(NewsV1Motd left, NewsV1Motd right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV1Motd left, NewsV1Motd right)
		{
			return !Equals(left, right);
		}
	}
}