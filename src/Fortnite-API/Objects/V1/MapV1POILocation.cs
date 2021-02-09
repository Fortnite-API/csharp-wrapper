using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class MapV1POILocation : IEquatable<MapV1POILocation>
	{
		[J] public float X { get; private set; }
		[J] public float Y { get; private set; }
		[J] public float Z { get; private set; }

		public bool Equals(MapV1POILocation other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
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

			if (obj.GetType() != typeof(MapV1POILocation))
			{
				return false;
			}

			return Equals((MapV1POILocation)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = X.GetHashCode();
				hashCode = hashCode * 397 ^ Y.GetHashCode();
				hashCode = hashCode * 397 ^ Z.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(MapV1POILocation left, MapV1POILocation right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(MapV1POILocation left, MapV1POILocation right)
		{
			return !Equals(left, right);
		}
	}
}