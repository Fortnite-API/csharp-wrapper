using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Title) + "}")]
	public class NewsV2Motd : IEquatable<NewsV2Motd>
	{
		[J] public string Id { get; private set; }
		[J] public string Title { get; private set; }
		[J] public string TabTitle { get; private set; }
		[J] public string Body { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public Uri TileImage { get; private set; }
		[J] public int SortingPriority { get; private set; }
		[J] public bool Hidden { get; private set; }
		[J] public string VideoId { get; private set; }

		public bool Equals(NewsV2Motd other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Title == other.Title && TabTitle == other.TabTitle && Body == other.Body && Equals(Image, other.Image) && Equals(TileImage, other.TileImage) && SortingPriority == other.SortingPriority && Hidden == other.Hidden && VideoId == other.VideoId;
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

			return Equals((NewsV2Motd)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = (Id != null ? Id.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (TabTitle != null ? TabTitle.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Body != null ? Body.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (Image != null ? Image.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ (TileImage != null ? TileImage.GetHashCode() : 0);
				hashCode = (hashCode * 397) ^ SortingPriority;
				hashCode = (hashCode * 397) ^ Hidden.GetHashCode();
				hashCode = (hashCode * 397) ^ (VideoId != null ? VideoId.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(NewsV2Motd left, NewsV2Motd right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV2Motd left, NewsV2Motd right)
		{
			return !Equals(left, right);
		}
	}
}