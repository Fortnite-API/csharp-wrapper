using System;

using RestSharp;

namespace Fortnite_API.Objects.V2
{
	public class BrCosmeticV2SearchProperties
	{
		private static readonly DateTime _unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

		public Optional<GameLanguage> Language { get; set; }
		public Optional<GameLanguage> SearchLanguage { get; set; }
		public Optional<MatchMethod> MatchMethod { get; set; }
		public Optional<string> Id { get; set; }
		public Optional<string> Name { get; set; }
		public Optional<string> Description { get; set; }
		public Optional<string> Type { get; set; }
		public Optional<string> DisplayType { get; set; }
		public Optional<string> BackendType { get; set; }
		public Optional<string> Rarity { get; set; }
		public Optional<string> DisplayRarity { get; set; }
		public Optional<string> BackendRarity { get; set; }
		public Optional<bool> HasSeries { get; set; }
		public Optional<string> Series { get; set; }
		public Optional<string> BackendSeries { get; set; }
		public Optional<bool> HasSet { get; set; }
		public Optional<string> Set { get; set; }
		public Optional<string> SetText { get; set; }
		public Optional<string> BackendSet { get; set; }
		public Optional<bool> HasIntroduction { get; set; }
		public Optional<int> BackendIntroduction { get; set; }
		public Optional<string> IntroductionChapter { get; set; }
		public Optional<string> IntroductionSeason { get; set; }
		public Optional<bool> HasFeaturedImage { get; set; }
		public Optional<bool> HasVariants { get; set; }
		public Optional<bool> HasGameplayTags { get; set; }
		public Optional<string> GameplayTag { get; set; }
		public Optional<bool> HasMetaTags { get; set; }
		public Optional<string> MetaTag { get; set; }
		public Optional<string> DynamicPakId { get; set; }
		public Optional<DateTime> Added { get; set; }
		public Optional<DateTime> AddedSince { get; set; }
		public Optional<int> UnseenFor { get; set; }
		public Optional<DateTime> LastAppearance { get; set; }

		internal IRestRequest AppendParameters(IRestRequest request)
		{
			if (Language.HasValue)
			{
				request.AddQueryParameter("language", Language.Value.GetLanguageCode());
			}

			if (SearchLanguage.HasValue)
			{
				request.AddQueryParameter("searchLanguage", SearchLanguage.Value.GetLanguageCode());
			}

			if (MatchMethod.HasValue)
			{
				request.AddQueryParameter("matchMethod", MatchMethod.Value.GetString());
			}

			var paramsCount = request.Parameters.Count;

			if (Id.HasValue)
			{
				request.AddQueryParameter("id", Id.Value);
			}

			if (Name.HasValue)
			{
				request.AddQueryParameter("name", Name.Value);
			}

			if (Description.HasValue)
			{
				request.AddQueryParameter("description", Description.Value);
			}

			if (Type.HasValue)
			{
				request.AddQueryParameter("type", Type.Value);
			}

			if (DisplayType.HasValue)
			{
				request.AddQueryParameter("displayType", DisplayType.Value);
			}

			if (BackendType.HasValue)
			{
				request.AddQueryParameter("backendType", BackendType.Value);
			}

			if (Rarity.HasValue)
			{
				request.AddQueryParameter("rarity", Rarity.Value);
			}

			if (DisplayRarity.HasValue)
			{
				request.AddQueryParameter("displayRarity", DisplayRarity.Value);
			}

			if (BackendRarity.HasValue)
			{
				request.AddQueryParameter("backendRarity", BackendRarity.Value);
			}

			if (HasSeries.HasValue)
			{
				request.AddQueryParameter("hasSeries", HasSeries.Value.GetString());
			}

			if (Series.HasValue)
			{
				request.AddQueryParameter("series", Series.Value);
			}

			if (BackendSeries.HasValue)
			{
				request.AddQueryParameter("backendSeries", BackendSeries.Value);
			}

			if (HasSet.HasValue)
			{
				request.AddQueryParameter("hasSet", HasSet.Value.GetString());
			}

			if (Set.HasValue)
			{
				request.AddQueryParameter("set", Set.Value);
			}

			if (SetText.HasValue)
			{
				request.AddQueryParameter("setText", SetText.Value);
			}

			if (BackendSet.HasValue)
			{
				request.AddQueryParameter("backendSet", BackendSet.Value);
			}

			if (HasIntroduction.HasValue)
			{
				request.AddQueryParameter("hasIntroduction", HasIntroduction.Value.GetString());
			}

			if (BackendIntroduction.HasValue)
			{
				request.AddQueryParameter("backendIntroduction", BackendIntroduction.Value.ToString());
			}

			if (IntroductionChapter.HasValue)
			{
				request.AddQueryParameter("introductionChapter", IntroductionChapter.Value);
			}

			if (IntroductionSeason.HasValue)
			{
				request.AddQueryParameter("introductionSeason", IntroductionSeason.Value);
			}

			if (HasFeaturedImage.HasValue)
			{
				request.AddQueryParameter("hasFeaturedImage", HasFeaturedImage.Value.GetString());
			}

			if (HasVariants.HasValue)
			{
				request.AddQueryParameter("hasVariants", HasVariants.Value.GetString());
			}

			if (HasGameplayTags.HasValue)
			{
				request.AddQueryParameter("hasGameplayTags", HasGameplayTags.Value.GetString());
			}

			if (GameplayTag.HasValue)
			{
				request.AddQueryParameter("gameplayTag", GameplayTag.Value);
			}

			if (HasMetaTags.HasValue)
			{
				request.AddQueryParameter("hasMetaTags", HasMetaTags.Value.GetString());
			}

			if (MetaTag.HasValue)
			{
				request.AddQueryParameter("metaTag", GameplayTag.Value);
			}

			if (DynamicPakId.HasValue)
			{
				request.AddQueryParameter("dynamicPakId", DynamicPakId.Value);
			}

			if (Added.HasValue)
			{
				if (Added.Value <= _unixEpoch)
				{
					throw new ArgumentOutOfRangeException(nameof(Added), Added.Value, null);
				}

				request.AddQueryParameter("added", (Added.Value - _unixEpoch).TotalSeconds.ToString("0"));
			}

			if (AddedSince.HasValue)
			{
				if (AddedSince.Value <= _unixEpoch)
				{
					throw new ArgumentOutOfRangeException(nameof(AddedSince), AddedSince.Value, null);
				}

				request.AddQueryParameter("addedSince", (AddedSince.Value - _unixEpoch).TotalSeconds.ToString("0"));
			}

			if (UnseenFor.HasValue)
			{
				request.AddQueryParameter("unseenFor", UnseenFor.Value.ToString());
			}

			if (LastAppearance.HasValue)
			{
				if (LastAppearance.Value <= _unixEpoch)
				{
					throw new ArgumentOutOfRangeException(nameof(LastAppearance), LastAppearance.Value, null);
				}

				request.AddQueryParameter("lastAppearance", (LastAppearance.Value - _unixEpoch).TotalSeconds.ToString("0"));
			}

			if (request.Parameters.Count - paramsCount == 0)
			{
				throw new ArgumentException("at least one search parameter is required");
			}

			return request;
		}
	}
}