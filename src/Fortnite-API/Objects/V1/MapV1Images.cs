using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class MapV1Images : IEquatable<MapV1Images>
	{
		[J] public Uri Blank { get; private set; }
		[J] public Uri POIs { get; private set; }

		public bool Equals(MapV1Images other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Blank, other.Blank) && Equals(POIs, other.POIs);
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

			if (obj.GetType() != typeof(MapV1Images))
			{
				return false;
			}

			return Equals((MapV1Images)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Blank != null ? Blank.GetHashCode() : 0) * 397 ^ (POIs != null ? POIs.GetHashCode() : 0);
			}
		}

		public static bool operator ==(MapV1Images left, MapV1Images right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(MapV1Images left, MapV1Images right)
		{
			return !Equals(left, right);
		}
	}
}