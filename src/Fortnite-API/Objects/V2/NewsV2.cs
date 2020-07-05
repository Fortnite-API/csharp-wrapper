using System;
using System.Collections.Generic;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Date) + "}")]
	public class NewsV2 : IEquatable<NewsV2>
	{
		[J] public string Hash { get; private set; }
		[J] public DateTime Date { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public List<NewsV2Motd> Motds { get; private set; }
		[J] public List<NewsV2Message> Messages { get; private set; }

		public bool Equals(NewsV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Hash == other.Hash && Date.Equals(other.Date);
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

			return Equals((NewsV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Hash.GetHashCode() * 397 ^ Date.GetHashCode();
			}
		}

		public static bool operator ==(NewsV2 left, NewsV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(NewsV2 left, NewsV2 right)
		{
			return !Equals(left, right);
		}
	}
}