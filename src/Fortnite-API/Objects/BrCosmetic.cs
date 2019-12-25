using System;
using System.Collections.Generic;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class BrCosmetic : IEquatable<BrCosmetic>
	{
		[J("id")] public string Id { get; private set; }
		[J("type")] public BrCosmeticType Type { get; private set; }
		[J("backendType")] public string BackendType { get; private set; }
		[J("rarity")] public BrCosmeticRarity Rarity { get; private set; }
		[J("displayRarity")] public string DisplayRarity { get; private set; }
		[J("backendRarity")] public string BackendRarity { get; private set; }
		[J("name")] public string Name { get; private set; }
		[J("shortDescription")] public string ShortDescription { get; private set; }
		[J("description")] public string Description { get; private set; }
		[J("set")] public string Set { get; private set; }
		[J("setText")] public string SetText { get; private set; }
		[J("series")] public string Series { get; private set; }
		[J("backendSeries")] public string BackendSeries { get; private set; }
		[J("images")] public BrCosmeticImages Images { get; private set; }
		[J("variants")] public List<BrCosmeticVariant> Variants { get; private set; }
		[J("gameplayTags")] public List<string> GameplayTags { get; private set; }
		[J("displayAssetPath")] public string DisplayAssetPath { get; private set; }
		[J("definition")] public string Definition { get; private set; }
		[J("requiredItemId")] public string RequiredItemId { get; private set; }
		[J("builtInEmoteId")] public string BuiltInEmoteId { get; private set; }
		[J("path")] public string Path { get; private set; }
		[J("lastUpdate")] public DateTime LastUpdate { get; private set; }
		[J("added")] public DateTime Added { get; private set; }

		[I] public bool HasSet => Set != null;
		[I] public bool HasSetText => SetText != null;
		[I] public bool HasSeries => Series != null;
		[I] public bool HasDisplayAssetPath => DisplayAssetPath != null;
		[I] public bool HasDefinition => Definition != null;
		[I] public bool HasRequiredItemId => RequiredItemId != null;
		[I] public bool HasBuiltInEmoteId => BuiltInEmoteId != null;
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

		public bool TryGetVariant(string variantType, out BrCosmeticVariant outVariant)
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

		public bool TryGetVariantByChannel(string variantChannel, out BrCosmeticVariant outVariant)
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

		public bool Equals(BrCosmetic other)
		{
			if (ReferenceEquals(null, other))
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return Id == other.Id && Path == other.Path && LastUpdate.Equals(other.LastUpdate) && Added.Equals(other.Added);
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

			if (obj.GetType() != typeof(BrCosmetic))
			{
				return false;
			}

			return Equals((BrCosmetic)obj);
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Path, LastUpdate, Added);
		}

		public static bool operator ==(BrCosmetic left, BrCosmetic right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmetic left, BrCosmetic right)
		{
			return !Equals(left, right);
		}
	}
}