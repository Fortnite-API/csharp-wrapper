namespace Fortnite_API.Objects
{
	public class BrCosmeticSearchProperties
	{
		public Optional<GameLanguage> Language;
		public Optional<GameLanguage> SearchLanguage;
		public Optional<MatchMethod> MatchMethod;
		public Optional<BrCosmeticType> Type { get; set; }
		public Optional<string> BackendType { get; set; }
		public Optional<BrCosmeticRarity> Rarity { get; set; }
		public Optional<string> DisplayRarity { get; set; }
		public Optional<string> BackendRarity { get; set; }
		public Optional<string> Name { get; set; }
		public Optional<string> ShortDescription { get; set; }
		public Optional<string> Description { get; set; }
		public Optional<string> Set { get; set; }
		public Optional<string> SetText { get; set; }
		public Optional<string> Series { get; set; }
		public Optional<string> BackendSeries { get; set; }
		public Optional<bool> HasSmallIcon { get; set; }
		public Optional<bool> HasIcon { get; set; }
		public Optional<bool> HasFeaturedImage { get; set; }
		public Optional<bool> HasBackgroundImage { get; set; }
		public Optional<bool> HasCoverArt { get; set; }
		public Optional<bool> HasDecal { get; set; }
		public Optional<bool> HasVariants { get; set; }
		public Optional<bool> HasGameplayTags { get; set; }
		public Optional<string> GameplayTag { get; set; }
	}
}