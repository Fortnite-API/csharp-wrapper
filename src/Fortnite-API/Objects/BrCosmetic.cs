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

		[I]public bool HasSet => Set != null;
		[I]public bool HasSetText => SetText != null;
		[I]public bool HasSeries => Series != null;
		[I]public bool HasDisplayAssetPath => DisplayAssetPath != null;
		[I]public bool HasDefinition => Definition != null;
		[I]public bool HasRequiredItemId => RequiredItemId != null;
		[I]public bool HasBuiltInEmoteId => BuiltInEmoteId != null;
		[I]public bool HasVariants => Variants != null && Variants.Count != 0;
		[I]public bool HasGameplayTags => GameplayTags != null && GameplayTags.Count != 0;

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

		public bool TryGetVariant(string type, out BrCosmeticVariant outVariant)
		{
			if (!HasVariants)
			{
				outVariant = null;
				return false;
			}

			foreach (var variant in Variants)
			{
				if (string.IsNullOrWhiteSpace(type))
				{
					if (variant.Type != null)
					{
						continue;
					}

					outVariant = variant;
					return true;
				}

				if (!string.Equals(variant.Type, type, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}

				outVariant = variant;
				return true;
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

			return Id == other.Id;
		}

		public override bool Equals(object obj)
		{
			if (obj is BrCosmetic brCosmetic)
			{
				return Equals(brCosmetic);
			}

			return false;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
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