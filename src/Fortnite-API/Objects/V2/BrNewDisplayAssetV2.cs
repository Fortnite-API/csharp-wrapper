using System;
using System.Collections.Generic;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Id) + "}")]
	public class BrNewDisplayAssetV2 : IEquatable<BrNewDisplayAssetV2>
	{
		[J] public string Id { get; private set; }
		[J] public string CosmeticId { get; private set; }
		[J] public List<BrMaterialInstanceV2> MaterialInstances { get; private set; }

		[I] public bool HasCosmeticId => CosmeticId != null;

		public bool Equals(BrNewDisplayAssetV2 other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && MaterialInstances.Equals(other.MaterialInstances);
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

			return Equals((BrNewDisplayAssetV2)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return Id.GetHashCode() * 397 ^ MaterialInstances.GetHashCode();
			}
		}

		public static bool operator ==(BrNewDisplayAssetV2 left, BrNewDisplayAssetV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrNewDisplayAssetV2 left, BrNewDisplayAssetV2 right)
		{
			return !Equals(left, right);
		}
	}
}