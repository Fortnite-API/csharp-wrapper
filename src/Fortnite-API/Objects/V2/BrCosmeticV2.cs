using System;
using System.Collections.Generic;
using System.Diagnostics;

using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V2
{
	[DebuggerDisplay("{" + nameof(Id) + "}")]
	public class BrCosmeticV2 : IEquatable<BrCosmeticV2>
	{
		private static readonly Uri _youtubeBaseUri = new Uri("https://youtu.be/", UriKind.Absolute);

		[J] public string Id { get; private set; }
		[J] public string Name { get; private set; }
		[J] public string Description { get; private set; }
		[J] public string ExclusiveDescription { get; private set; }
		[J] public string UnlockRequirements { get; private set; }
		[J] public string CustomExclusiveCallout { get; private set; }
		[J] public BrCosmeticV2Type Type { get; private set; }
		[J] public BrCosmeticV2Rarity Rarity { get; private set; }
		[J] public BrCosmeticV2Series Series { get; private set; }
		[J] public BrCosmeticV2Set Set { get; private set; }
		[J] public BrCosmeticV2Introduction Introduction { get; private set; }
		[J] public BrCosmeticV2Images Images { get; private set; }
		[J] public List<BrCosmeticV2Variant> Variants { get; private set; }
		[J] public List<string> BuiltInEmoteIds { get; private set; }
		[J] public List<string> GameplayTags { get; private set; }
		[J] public List<string> MetaTags { get; private set; }
			private string _showcaseVideo;
		[J] public string ShowcaseVideo
		{
			get => _showcaseVideo;
			private set => ShowcaseVideoUri = _showcaseVideo == null ? null : new Uri(_youtubeBaseUri, _showcaseVideo = value);
		}
		[I] public Uri ShowcaseVideoUri { get; private set; }
		[J] public string DynamicPakId { get; private set; }
		[J] public string DisplayAssetPath { get; private set; }
		[J] public string DefinitionPath { get; private set; }
		[J] public string Path { get; private set; }
		[J] public DateTime Added { get; private set; }
		[J] public List<DateTime> ShopHistory { get; private set; }

		[I] public bool HasSeries => Series != null;
		[I] public bool HasSet => Set != null;
		[I] public bool HasIntroduction => Introduction != null;
		[I] public bool HasVariants => Variants != null && Variants.Count != 0;
		[I] public bool HasBuiltInEmoteIds => BuiltInEmoteIds != null && BuiltInEmoteIds.Count != 0;
		[I] public bool HasGameplayTags => GameplayTags != null && GameplayTags.Count != 0;
		[I] public bool HasMetaTags => MetaTags != null && MetaTags.Count != 0;
		[I] public bool HasShowcaseVideo => ShowcaseVideo != null;
		[I] public bool HasDynamicPakId => DynamicPakId != null;
		[I] public bool HasDisplayAssetPath => DisplayAssetPath != null;
		[I] public bool HasDefinitionPath => DefinitionPath != null;
		[I] public bool HasShopHistory => ShopHistory != null;

		public bool Equals(BrCosmeticV2 other)
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

			return Equals((BrCosmeticV2)obj);
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}

		public static bool operator ==(BrCosmeticV2 left, BrCosmeticV2 right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(BrCosmeticV2 left, BrCosmeticV2 right)
		{
			return !Equals(left, right);
		}
	}
}