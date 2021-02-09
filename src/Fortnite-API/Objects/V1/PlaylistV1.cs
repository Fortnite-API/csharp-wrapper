using System;
using System.Collections.Generic;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	[DebuggerDisplay("{" + nameof(Id) + "}")]
	public class PlaylistV1 : IEquatable<PlaylistV1>
	{
		[J] public string Id { get; private set; }
		[J] public string Name { get; private set; }
		[J] public string SubName { get; private set; }
		[J] public string Description { get; private set; }
		[J] public string GameType { get; private set; }
		[J] public string RatingType { get; private set; }
		[J] public int MinPlayers { get; private set; }
		[J] public int MaxPlayers { get; private set; }
		[J] public int MaxTeams { get; private set; }
		[J] public int MaxTeamSize { get; private set; }
		[J] public int MaxSquads { get; private set; }
		[J] public int MaxSquadSize { get; private set; }
		[J] public bool IsDefault { get; private set; }
		[J] public bool IsTournament { get; private set; }
		[J] public bool IsLimitedTimeMode { get; private set; }
		[J] public bool IsLargeTeamGame { get; private set; }
		[J] public bool AccumulateToProfileStats { get; private set; }
		[J] public PlaylistV1Images Images { get; private set; }
		[J] public List<string> GameplayTags { get; private set; }
		[J] public string Path { get; private set; }
		[J] public DateTime Added { get; private set; }

		[I] public bool HasGameplayTags => GameplayTags != null && GameplayTags.Count != 0;

		public bool Equals(PlaylistV1 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Path == other.Path && Added.Equals(other.Added);
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

			return Equals((PlaylistV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id.GetHashCode();
				hashCode = hashCode * 397 ^ Path.GetHashCode();
				hashCode = hashCode * 397 ^ Added.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(PlaylistV1 left, PlaylistV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(PlaylistV1 left, PlaylistV1 right)
		{
			return !Equals(left, right);
		}
	}
}