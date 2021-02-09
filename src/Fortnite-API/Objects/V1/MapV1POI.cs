using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class MapV1POI : IEquatable<MapV1POI>
	{
		[J] public string Id { get; private set; }
		[J] public string Name { get; private set; }
		[J] public MapV1POILocation Location { get; private set; }

		public bool Equals(MapV1POI other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Name == other.Name && Equals(Location, other.Location);
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

			if (obj.GetType() != typeof(MapV1POI))
			{
				return false;
			}

			return Equals((MapV1POI)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id.GetHashCode();
				hashCode = hashCode * 397 ^ (Name != null ? Name.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Location != null ? Location.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(MapV1POI left, MapV1POI right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(MapV1POI left, MapV1POI right)
		{
			return !Equals(left, right);
		}
	}
}