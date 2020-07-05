using System;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrStatsV2V1Stats : IEquatable<BrStatsV2V1Stats>
	{
		[J] public BrStatsV2V1StatsPlatform All { get; private set; }
		[J] public BrStatsV2V1StatsPlatform KeyboardMouse { get; private set; }
		[J] public BrStatsV2V1StatsPlatform Gamepad { get; private set; }
		[J] public BrStatsV2V1StatsPlatform Touch { get; private set; }

		public bool Equals(BrStatsV2V1Stats other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Equals(All, other.All) && Equals(KeyboardMouse, other.KeyboardMouse) && Equals(Gamepad, other.Gamepad) && Equals(Touch, other.Touch);
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

			return Equals((BrStatsV2V1Stats)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = All.GetHashCode();
				hashCode = hashCode * 397 ^ (KeyboardMouse != null ? KeyboardMouse.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Gamepad != null ? Gamepad.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Touch != null ? Touch.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrStatsV2V1Stats left, BrStatsV2V1Stats right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrStatsV2V1Stats left, BrStatsV2V1Stats right)
		{
			return !Equals(left, right);
		}
	}
}