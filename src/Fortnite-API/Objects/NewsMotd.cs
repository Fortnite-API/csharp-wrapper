using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class NewsMotd : IEquatable<NewsMotd>
	{
		[J("id")] public string Id { get; private set; }
		[J("title")] public string Title { get; private set; }
		[J("body")] public string Body { get; private set; }
		[J("image")] public Uri Image { get; private set; }
		[J("tileImage")] public Uri TileImage { get; private set; }
		[J("hidden")] public bool Hidden { get; private set; }
		[J("spotlight")] public bool Spotlight { get; private set; }
		[J("type")] public string Type { get; private set; }
		[J("entryType")] public string EntryType { get; private set; }

		public bool Equals(NewsMotd other)
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

			if (obj.GetType() != typeof(NewsMotd))
			{
				return false;
			}

			return Equals((NewsMotd)obj);
		}

		public override int GetHashCode()
		{
			var hashCode = new HashCode();
			hashCode.Add(Id);
			hashCode.Add(Title);
			hashCode.Add(Body);
			hashCode.Add(Image);
			hashCode.Add(TileImage);
			hashCode.Add(Hidden);
			hashCode.Add(Spotlight);
			hashCode.Add(Type);
			hashCode.Add(EntryType);
			return hashCode.ToHashCode();
		}

		public static bool operator ==(NewsMotd left, NewsMotd right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsMotd left, NewsMotd right)
		{
			return !Equals(left, right);
		}
	}
}