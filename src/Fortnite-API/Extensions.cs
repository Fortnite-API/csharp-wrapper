using System;
using System.Runtime.CompilerServices;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API
{
	internal static class Extensions
	{
		public static string GetLanguageCode(this GameLanguage language)
		{
			switch (language)
			{
				case GameLanguage.EN:
					return "en";
				case GameLanguage.AR:
					return "ar";
				case GameLanguage.DE:
					return "de";
				case GameLanguage.ES_419:
					return "es-419";
				case GameLanguage.ES:
					return "es";
				case GameLanguage.FR:
					return "fr";
				case GameLanguage.IT:
					return "it";
				case GameLanguage.JA:
					return "ja";
				case GameLanguage.KO:
					return "ko";
				case GameLanguage.PL:
					return "pl";
				case GameLanguage.PT_BR:
					return "pt-BR";
				case GameLanguage.RU:
					return "ru";
				case GameLanguage.TR:
					return "tr";
				case GameLanguage.ZH_CN:
					return "zh-CN";
				case GameLanguage.ZH_HANT:
					return "zh-Hant";
				default:
					throw new ArgumentOutOfRangeException(nameof(language));
			}
		}

		public static string GetString(this AesV2KeyFormat keyFormat)
		{
			switch (keyFormat)
			{
				case AesV2KeyFormat.Hex:
					return "hex";
				case AesV2KeyFormat.Base64:
					return "base64";
				default:
					throw new ArgumentOutOfRangeException(nameof(keyFormat), keyFormat, null);
			}
		}

		public static string GetString(this BrStatsV2V1TimeWindow timeWindow)
		{
			switch (timeWindow)
			{
				case BrStatsV2V1TimeWindow.Lifetime:
					return "lifetime";
				case BrStatsV2V1TimeWindow.Season:
					return "season";
				default:
					throw new ArgumentOutOfRangeException(nameof(timeWindow), timeWindow, null);
			}
		}

		public static string GetString(this BrStatsV2V1AccountType accountType)
		{
			switch (accountType)
			{
				case BrStatsV2V1AccountType.Epic:
					return "epic";
				case BrStatsV2V1AccountType.PSN:
					return "psn";
				case BrStatsV2V1AccountType.XBL:
					return "xbl";
				default:
					throw new ArgumentOutOfRangeException(nameof(accountType), accountType, null);
			}
		}

		public static string GetString(this BrStatsV2V1ImagePlatform imagePlatform)
		{
			switch (imagePlatform)
			{
				case BrStatsV2V1ImagePlatform.None:
					return "none";
				case BrStatsV2V1ImagePlatform.All:
					return "all";
				case BrStatsV2V1ImagePlatform.KeyboardMouse:
					return "keyboardMouse";
				case BrStatsV2V1ImagePlatform.Gamepad:
					return "gamepad";
				case BrStatsV2V1ImagePlatform.Touch:
					return "touch";
				default:
					throw new ArgumentOutOfRangeException(nameof(imagePlatform), imagePlatform, null);
			}
		}

		public static string GetString(this MatchMethod matchMethod)
		{
			switch (matchMethod)
			{
				case MatchMethod.Full:
					return "full";
				case MatchMethod.Contains:
					return "contains";
				case MatchMethod.Starts:
					return "starts";
				case MatchMethod.Ends:
					return "ends";
				default:
					throw new ArgumentOutOfRangeException(nameof(matchMethod), matchMethod, null);
			}
		}

		public static string GetString(this BrCosmeticV1Type brCosmeticType)
		{
			switch (brCosmeticType)
			{
				case BrCosmeticV1Type.Banner:
					return "banner";
				case BrCosmeticV1Type.Backpack:
					return "backpack";
				case BrCosmeticV1Type.Contrail:
					return "contrail";
				case BrCosmeticV1Type.Outfit:
					return "outfit";
				case BrCosmeticV1Type.Emote:
					return "emote";
				case BrCosmeticV1Type.Emoji:
					return "emoji";
				case BrCosmeticV1Type.Glider:
					return "glider";
				case BrCosmeticV1Type.Wrap:
					return "wrap";
				case BrCosmeticV1Type.LoadingScreen:
					return "loadingscreen";
				case BrCosmeticV1Type.Music:
					return "music";
				case BrCosmeticV1Type.Pet:
					return "pet";
				case BrCosmeticV1Type.PetCarrier:
					return "petcarrier";
				case BrCosmeticV1Type.Pickaxe:
					return "pickaxe";
				case BrCosmeticV1Type.Spray:
					return "spray";
				case BrCosmeticV1Type.Toy:
					return "toy";
				case BrCosmeticV1Type.Shout:
					return "shout";
				default:
					throw new ArgumentOutOfRangeException(nameof(brCosmeticType), brCosmeticType, null);
			}
		}

		public static string GetString(this BrCosmeticV1Rarity brCosmeticRarity)
		{
			switch (brCosmeticRarity)
			{
				case BrCosmeticV1Rarity.Frozen:
					return "frozen";
				case BrCosmeticV1Rarity.Lava:
					return "lava";
				case BrCosmeticV1Rarity.Legendary:
					return "legendary";
				case BrCosmeticV1Rarity.Dark:
					return "dark";
				case BrCosmeticV1Rarity.StarWars:
					return "starwars";
				case BrCosmeticV1Rarity.Marvel:
					return "marvel";
				case BrCosmeticV1Rarity.DC:
					return "dc";
				case BrCosmeticV1Rarity.Icon:
					return "icon";
				case BrCosmeticV1Rarity.Shadow:
					return "shadow";
				case BrCosmeticV1Rarity.Epic:
					return "epic";
				case BrCosmeticV1Rarity.Rare:
					return "rare";
				case BrCosmeticV1Rarity.Uncommon:
					return "uncommon";
				case BrCosmeticV1Rarity.Common:
					return "common";
				case BrCosmeticV1Rarity.Slurp:
					return "slurp";
				default:
					throw new ArgumentOutOfRangeException(nameof(brCosmeticRarity), brCosmeticRarity, null);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string GetString(this bool boolean)
		{
			return boolean ? "true" : "false";
		}

		public static IRestRequest ApplySearchParameters(this IRestRequest request, Action<BrCosmeticV2SearchProperties> func)
		{
			var searchProperties = new BrCosmeticV2SearchProperties();
			func(searchProperties);

			return searchProperties.AppendParameters(request);
		}

		public static IRestRequest ApplySearchParameters(this IRestRequest request, Action<BrCosmeticV1SearchProperties> func)
		{
			var searchProperties = new BrCosmeticV1SearchProperties();
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