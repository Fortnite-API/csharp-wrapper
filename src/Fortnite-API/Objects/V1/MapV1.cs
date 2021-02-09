using System;
using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class MapV1 : IEquatable<MapV1>
	{
		[J] public MapV1Images Images { get; private set; }
		[J] public List<MapV1POI> POIs { get; private set; }

		public bool Equals(MapV1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Images.Equals(other.Images) && POIs.Equals(other.POIs);
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

			if (obj.GetType() != typeof(MapV1))
			{
				return false;
			}

			return Equals((MapV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Images.GetHashCode() * 397 ^ POIs.GetHashCode();
			}
		}

		public static bool operator ==(MapV1 left, MapV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(MapV1 left, MapV1 right)
		{
			return !Equals(left, right);
		}
	}
}