using System;
using System.Collections.Generic;
using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Channel) + "}")]
	public class BrCosmeticV2Variant : IEquatable<BrCosmeticV2Variant>
	{
		[J] public string Channel { get; private set; }
		[J] public string Type { get; private set; }
		[J] public List<BrCosmeticV2VariantOption> Options { get; private set; }

		public bool Equals(BrCosmeticV2Variant other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Channel == other.Channel && Options.Equals(other.Options);
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

			return Equals((BrCosmeticV2Variant)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Channel.GetHashCode() * 397 ^ Options.GetHashCode();
			}
		}

		public static bool operator ==(BrCosmeticV2Variant left, BrCosmeticV2Variant right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2Variant left, BrCosmeticV2Variant right)
		{
			return !Equals(left, right);
		}
	}
}