using System;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API
{
	internal static class Extensions
	{
		public static string GetLanguageCode(this GameLanguage language)
		{
			return language switch
			{
				GameLanguage.EN => "en",
				GameLanguage.AR => "ar",
				GameLanguage.DE => "de",
				GameLanguage.ES_419 => "es-419",
				GameLanguage.ES => "es",
				GameLanguage.FR => "fr",
				GameLanguage.IT => "it",
				GameLanguage.JA => "ja",
				GameLanguage.KO => "ko",
				GameLanguage.PL => "pl",
				GameLanguage.PT_BR => "pt-BR",
				GameLanguage.RU => "ru",
				GameLanguage.TR => "tr",
				GameLanguage.ZH_CN => "zh-CN",
				GameLanguage.ZH_HANT => "zh-Hant",
				_ => throw new ArgumentOutOfRangeException(nameof(language))
			};
		}

		public static string GetString(this MatchMethod matchMethod)
		{
			return matchMethod switch
			{
				MatchMethod.Full => "full",
				MatchMethod.Contains => "contains",
				MatchMethod.Starts => "starts",
				MatchMethod.Ends => "ends",
				_ => throw new ArgumentOutOfRangeException(nameof(matchMethod))
			};
		}

		public static string GetString(this BrCosmeticType brCosmeticType)
		{
			return brCosmeticType switch
			{
				BrCosmeticType.Banner => "banner",
				BrCosmeticType.Backpack => "backpack",
				BrCosmeticType.Contrail => "contrail",
				BrCosmeticType.Outfit => "outfit",
				BrCosmeticType.Emote => "emote",
				BrCosmeticType.Emoji => "emoji",
				BrCosmeticType.Glider => "glider",
				BrCosmeticType.Wrap => "wrap",
				BrCosmeticType.LoadingScreen => "loadingscreen",
				BrCosmeticType.Music => "music",
				BrCosmeticType.Pet => "pet",
				BrCosmeticType.Pickaxe => "pickaxe",
				BrCosmeticType.Spray => "spray",
				BrCosmeticType.Toy => "toy",
				_ => throw new ArgumentOutOfRangeException(nameof(brCosmeticType))
			};
		}

		public static string GetString(this BrCosmeticRarity brCosmeticRarity)
		{
			return brCosmeticRarity switch
			{
				BrCosmeticRarity.Frozen => "frozen",
				BrCosmeticRarity.Lava => "lava",
				BrCosmeticRarity.Legendary => "legendary",
				BrCosmeticRarity.Dark => "dark",
				BrCosmeticRarity.StarWars => "starwars",
				BrCosmeticRarity.Marvel => "marvel",
				BrCosmeticRarity.DC => "dc",
				BrCosmeticRarity.Icon => "icon",
				BrCosmeticRarity.Shadow => "shadow",
				BrCosmeticRarity.Epic => "epic",
				BrCosmeticRarity.Rare => "rare",
				BrCosmeticRarity.Uncommon => "uncommon",
				BrCosmeticRarity.Common => "common",
				_ => throw new ArgumentOutOfRangeException(nameof(brCosmeticRarity))
			};
		}

		public static string GetString(this bool boolean)
		{
			return boolean ? "true" : "false";
		}

		public static RestRequest ApplySearchParameters(this RestRequest request, Action<BrCosmeticSearchProperties> func)
		{
			var searchProperties = new BrCosmeticSearchProperties();
			func(searchProperties);
			var hasOneOrMoreParameters = false;

			if (searchProperties.Language.HasValue)
			{
				request.AddQueryParameter("language", searchProperties.Language.Value.GetLanguageCode());
			}

			if (searchProperties.SearchLanguage.HasValue)
			{
				request.AddQueryParameter("searchLanguage", searchProperties.SearchLanguage.Value.GetLanguageCode());
			}

			if (searchProperties.MatchMethod.HasValue)
			{
				request.AddQueryParameter("matchMethod", searchProperties.MatchMethod.Value.GetString());
			}

			if (searchProperties.Type.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("type", searchProperties.Type.Value.GetString());
			}

			if (searchProperties.BackendType.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("backendType", searchProperties.BackendType.Value);
			}

			if (searchProperties.Rarity.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("rarity", searchProperties.Rarity.Value.GetString());
			}

			if (searchProperties.DisplayRarity.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("displayRarity", searchProperties.DisplayRarity.Value);
			}

			if (searchProperties.BackendRarity.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("backendRarity", searchProperties.BackendRarity.Value);
			}

			if (searchProperties.Name.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("name", searchProperties.Name.Value);
			}

			if (searchProperties.ShortDescription.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("shortDescription", searchProperties.ShortDescription.Value);
			}

			if (searchProperties.Description.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("description", searchProperties.Description.Value);
			}

			if (searchProperties.Set.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("set", searchProperties.Set.Value);
			}

			if (searchProperties.SetText.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("setText", searchProperties.SetText.Value);
			}

			if (searchProperties.Series.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("series", searchProperties.Series.Value);
			}

			if (searchProperties.BackendSeries.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("backendSeries", searchProperties.BackendSeries.Value);
			}

			if (searchProperties.HasSmallIcon.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasSmallIcon", searchProperties.HasSmallIcon.Value.GetString());
			}

			if (searchProperties.HasIcon.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasIcon", searchProperties.HasIcon.Value.GetString());
			}

			if (searchProperties.HasFeaturedImage.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasFeaturedImage", searchProperties.HasFeaturedImage.Value.GetString());
			}

			if (searchProperties.HasBackgroundImage.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasBackgroundImage", searchProperties.HasBackgroundImage.Value.GetString());
			}

			if (searchProperties.HasCoverArt.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasCoverArt", searchProperties.HasCoverArt.Value.GetString());
			}

			if (searchProperties.HasDecal.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasDecal", searchProperties.HasDecal.Value.GetString());
			}

			if (searchProperties.HasVariants.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasVariants", searchProperties.HasVariants.Value.GetString());
			}

			if (searchProperties.HasGameplayTags.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("hasGameplayTags", searchProperties.HasGameplayTags.Value.GetString());
			}

			if (searchProperties.GameplayTag.HasValue)
			{
				hasOneOrMoreParameters = true;
				request.AddQueryParameter("gameplayTag", searchProperties.GameplayTag.Value);
			}

			if (!hasOneOrMoreParameters)
			{
				throw new ArgumentException("at least one search parameter is required");
			}

			return request;
		}

	}
}