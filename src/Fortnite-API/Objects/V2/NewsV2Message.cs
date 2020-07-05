using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Title) + "}")]
	public class NewsV2Message : IEquatable<NewsV2Message>
	{
		[J] public string Title { get; private set; }
		[J] public string Body { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public string Adspace { get; private set; }

		public bool Equals(NewsV2Message other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Title == other.Title && Body == other.Body && Image == other.Image && Adspace == other.Adspace;
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

			return Equals((NewsV2Message)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Title != null ? Title.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Body != null ? Body.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Image != null ? Image.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Adspace != null ? Adspace.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(NewsV2Message left, NewsV2Message right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV2Message left, NewsV2Message right)
		{
			return !Equals(left, right);
		}
	}
}