using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(BackendValue) + "}")]
	public class BrShopV2StoreFrontEntryBanner : IEquatable<BrShopV2StoreFrontEntryBanner>
	{
		[J] public string Value { get; private set; }
		[J] public string Intensity { get; private set; }
		[J] public string BackendValue { get; private set; }

		public bool Equals(BrShopV2StoreFrontEntryBanner other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Value == other.Value && Intensity == other.Intensity && BackendValue == other.BackendValue;
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

			return Equals((BrShopV2StoreFrontEntryBanner)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Value != null ? Value.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Intensity != null ? Intensity.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (BackendValue != null ? BackendValue.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrShopV2StoreFrontEntryBanner left, BrShopV2StoreFrontEntryBanner right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2StoreFrontEntryBanner left, BrShopV2StoreFrontEntryBanner right)
		{
			return !Equals(left, right);
		}
	}
}