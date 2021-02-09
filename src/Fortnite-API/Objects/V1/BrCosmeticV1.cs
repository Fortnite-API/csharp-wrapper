using System;
using System.Collections.Generic;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrCosmeticV1 : IEquatable<BrCosmeticV1>
	{
		[J] public string Id { get; private set; }

		private string _typeString;

		[J("type")]
		public string TypeString
		{
			get => _typeString;
			private set => Type = Utilities.GetBrCosmeticV1Type(_typeString = value);
		}
		[I] public BrCosmeticV1Type Type { get; private set; } = BrCosmeticV1Type.Unknown;
		[J] public string BackendType { get; private set; }

		private string _rarityString;

		[J("rarity")]
		public string RarityString
		{
			get => _rarityString;
			private set => Rarity = Utilities.GetBrCosmeticV1Rarity(_rarityString = value);
		}
		[I] public BrCosmeticV1Rarity Rarity { get; private set; } = BrCosmeticV1Rarity.Unknown;
		[J] public string DisplayRarity { get; private set; }
		[J] public string BackendRarity { get; private set; }
		[J] public string Name { get; private set; }
		[J] public string ShortDescription { get; private set; }
		[J] public string Description { get; private set; }
		[J] public string Set { get; private set; }
		[J] public string SetText { get; private set; }
		[J] public string Series { get; private set; }
		[J] public string BackendSeries { get; private set; }
		[J] public BrCosmeticV1Images Images { get; private set; }
		[J] public List<BrCosmeticV1Variant> Variants { get; private set; }
		[J] public List<string> GameplayTags { get; private set; }
		[J] public string DisplayAssetPath { get; private set; }
		[J] public string Definition { get; private set; }
		[Obsolete("This property will always return null.")]
		public string RequiredItemId { get; } = null;
		[Obsolete("This property will always return null.")]
		public string BuiltInEmoteId { get; } = null;
		[J] public string Path { get; private set; }
		[Obsolete("This property will always return the same date as the 'Added' property.")]
		[J] public DateTime LastUpdate { get; private set; }
		[J] public DateTime Added { get; private set; }

		[I] public bool HasSet => Set != null;
		[I] public bool HasSetText => SetText != null;
		[I] public bool HasSeries => Series != null;
		[I] public bool HasDisplayAssetPath => DisplayAssetPath != null;
		[I] public bool HasDefinition => Definition != null;
		[Obsolete("This property will always return false.")]
		[I] public bool HasRequiredItemId { get; } = false;
		[Obsolete("This property will always return false.")]
		[I] public bool HasBuiltInEmoteId { get; } = false;
		[I] public bool HasVariants => Variants != null && Variants.Count != 0;
		[I] public bool HasGameplayTags => GameplayTags != null && GameplayTags.Count != 0;

		public bool HasGameplayTag(string gameplayTag)
		{
			if (gameplayTag == null)
			{
				throw new ArgumentNullException(nameof(gameplayTag));
			}

			if (gameplayTag.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(gameplayTag));
			}

			return HasGameplayTags && GameplayTags.Contains(gameplayTag);
		}

		public bool TryGetVariant(string variantType, out BrCosmeticV1Variant outVariant)
		{
			if (variantType == null)
			{
				throw new ArgumentNullException(nameof(variantType));
			}

			if (variantType.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(variantType));
			}

			if (HasVariants)
			{
				foreach (var variant in Variants)
				{
					if (!string.Equals(variant.Type, variantType, StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}

					outVariant = variant;
					return true;
				}
			}

			outVariant = null;
			return false;
		}

		public bool TryGetVariantByChannel(string variantChannel, out BrCosmeticV1Variant outVariant)
		{
			if (variantChannel == null)
			{
				throw new ArgumentNullException(nameof(variantChannel));
			}

			if (variantChannel.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(variantChannel));
			}

			if (HasVariants)
			{
				foreach (var variant in Variants)
				{
					if (!string.Equals(variant.Channel, variantChannel, StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}

					outVariant = variant;
					return true;
				}
			}

			outVariant = null;
			return false;
		}

		public bool Equals(BrCosmeticV1 other)
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

			if (obj.GetType() != typeof(BrCosmeticV1))
			{
				return false;
			}

			return Equals((BrCosmeticV1)obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Id != null ? Id.GetHashCode() : 0;
				hashCode = hashCode * 397 ^ (Path != null ? Path.GetHashCode() : 0);
				hashCode = hashCode * 397 ^ Added.GetHashCode();
				return hashCode;
			}
		}

		public static bool operator ==(BrCosmeticV1 left, BrCosmeticV1 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV1 left, BrCosmeticV1 right)
		{
			return !Equals(left, right);
		}
	}
}