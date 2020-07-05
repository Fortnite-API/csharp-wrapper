using System;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(BackendValue) + "}")]
	public class BrCosmeticV2Introduction : IEquatable<BrCosmeticV2Introduction>
	{
		[J] public string Chapter { get; private set; }
		[J] public string Season { get; private set; }
		[J] public string Text { get; private set; }
		[J] public int BackendValue { get; private set; }

		public bool Equals(BrCosmeticV2Introduction other)
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

			return Equals((BrCosmeticV2Introduction)obj);
		}

		public override int GetHashCode()
		{
			return BackendValue;
		}

		public static bool operator ==(BrCosmeticV2Introduction left, BrCosmeticV2Introduction right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2Introduction left, BrCosmeticV2Introduction right)
		{
			return !Equals(left, right);
		}
	}
}