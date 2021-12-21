using System;
using System.Collections.Generic;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Id) + "}")]
	public class BrMaterialInstanceV2 : IEquatable<BrMaterialInstanceV2>
	{
		[J] public string Id { get; private set; }
		[J] public Dictionary<string, Uri> Images { get; private set; }
		[J] public Dictionary<string, BrMaterialInstanceV2Color> Colors { get; private set; }
		[J] public Dictionary<string, float> Scalings { get; private set; }
		[J] public Dictionary<string, bool> Flags { get; private set; }

		[I] public bool HasImages => Images != null && Images.Count != 0;
		[I] public bool HasColors => Colors != null && Colors.Count != 0;
		[I] public bool HasScalings => Scalings != null && Scalings.Count != 0;
		[I] public bool HasFlags => Flags != null && Flags.Count != 0;

		public bool Equals(BrMaterialInstanceV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Equals(Images, other.Images) && Equals(Colors, other.Colors) && Equals(Scalings, other.Scalings);
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

			return Equals((BrMaterialInstanceV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id != null ? Id.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Images != null ? Images.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Colors != null ? Colors.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ (Scalings != null ? Scalings.GetHashCode() : 0);
				return hashCode;
			}
		}

		public static bool operator ==(BrMaterialInstanceV2 left, BrMaterialInstanceV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrMaterialInstanceV2 left, BrMaterialInstanceV2 right)
		{
			return !Equals(left, right);
		}
	}
}