using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(BackendValue) + "}")]
	public class BrCosmeticV2Set : IEquatable<BrCosmeticV2Set>
	{
		[J] public string Value { get; private set; }
		[J] public string Text { get; private set; }
		[J] public string BackendValue { get; private set; }

		public bool Equals(BrCosmeticV2Set other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return BackendValue == other.BackendValue;
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

			return Equals((BrCosmeticV2Set)obj);
		}

		public override int GetHashCode()
		{
			return BackendValue.GetHashCode();
		}

		public static bool operator ==(BrCosmeticV2Set left, BrCosmeticV2Set right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2Set left, BrCosmeticV2Set right)
		{
			return !Equals(left, right);
		}
	}
}