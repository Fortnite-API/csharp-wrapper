using System;
using System.Collections.Generic;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;
using I = Newtonsoft.Json.JsonIgnoreAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Entries) + "}")]
	public class BrShopV2StoreFront : IEquatable<BrShopV2StoreFront>
	{
		[J] public string Name { get; private set; }
		[J] public List<BrShopV2StoreFrontEntry> Entries { get; private set; }

		[I] public bool HasName => Name != null;

		public bool Equals(BrShopV2StoreFront other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Name == other.Name && Equals(Entries, other.Entries);
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

			return Equals((BrShopV2StoreFront)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Name != null ? Name.GetHashCode() : 0) * 397 ^ Entries.GetHashCode();
			}
		}

		public static bool operator ==(BrShopV2StoreFront left, BrShopV2StoreFront right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrShopV2StoreFront left, BrShopV2StoreFront right)
		{
			return !Equals(left, right);
		}
	}
}