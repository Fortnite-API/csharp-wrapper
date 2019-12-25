using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class CombinedNews : IEquatable<CombinedNews>
	{
		[J("br")] public News Br { get; private set; }
		[J("stw")] public News Stw { get; private set; }
		[J("creative")] public News Creative { get; private set; }

		public bool Equals(CombinedNews other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Br, other.Br) && Equals(Stw, other.Stw) && Equals(Creative, other.Creative);
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

			if (obj.GetType() != typeof(CombinedNews))
			{
				return false;
			}

			return Equals((CombinedNews)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Br, Stw, Creative);
		}

		public static bool operator ==(CombinedNews left, CombinedNews right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(CombinedNews left, CombinedNews right)
		{
			return !Equals(left, right);
		}
	}
}