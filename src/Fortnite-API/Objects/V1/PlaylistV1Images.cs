using System;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class PlaylistV1Images : IEquatable<PlaylistV1Images>
	{
		[J] public Uri Showcase { get; private set; }
		[J] public Uri MissionIcon { get; private set; }

		[I] public bool HasShowcase => Showcase != null;
		[I] public bool HasMissionIcon => MissionIcon != null;

		public bool Equals(PlaylistV1Images other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(Showcase, other.Showcase) && Equals(MissionIcon, other.MissionIcon);
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

			return Equals((PlaylistV1Images)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Showcase != null ? Showcase.GetHashCode() : 0) * 397 ^ (MissionIcon != null ? MissionIcon.GetHashCode() : 0);
			}
		}

		public static bool operator ==(PlaylistV1Images left, PlaylistV1Images right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(PlaylistV1Images left, PlaylistV1Images right)
		{
			return !Equals(left, right);
		}
	}
}