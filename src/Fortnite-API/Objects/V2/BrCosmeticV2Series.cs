using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(BackendValue) + "}")]
	public class BrCosmeticV2Series : IEquatable<BrCosmeticV2Series>
	{
		[J] public string Value { get; private set; }
		[J] public Uri Image { get; private set; }
		[J] public string BackendValue { get; private set; }

		public bool Equals(BrCosmeticV2Series other)
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

			return Equals((BrCosmeticV2Series)obj);
		}

		public override int GetHashCode()
		{
			return BackendValue.GetHashCode();
		}

		public static bool operator ==(BrCosmeticV2Series left, BrCosmeticV2Series right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2Series left, BrCosmeticV2Series right)
		{
			return !Equals(left, right);
		}
	}
}