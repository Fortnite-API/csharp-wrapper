using Fortnite_API.Objects.V1;

namespace Fortnite_API
{
	internal static class Utilities
	{
		public static BrCosmeticV1Type GetBrCosmeticV1Type(string typeString)
		{
			switch (typeString)
			{
				case "banner":
					return BrCosmeticV1Type.Banner;
				case "backpack":
					return BrCosmeticV1Type.Backpack;
				case "outfit":
					return BrCosmeticV1Type.Outfit;
				case "emote":
					return BrCosmeticV1Type.Emote;
				case "emoji":
					return BrCosmeticV1Type.Emoji;
				case "glider":
					return BrCosmeticV1Type.Glider;
				case "contrail":
					return BrCosmeticV1Type.Contrail;
				case "wrap":
					return BrCosmeticV1Type.Wrap;
				case "loadingscreen":
					return BrCosmeticV1Type.LoadingScreen;
				case "music":
					return BrCosmeticV1Type.Music;
				case "pet":
					return BrCosmeticV1Type.Pet;
				case "petcarrier":
					return BrCosmeticV1Type.PetCarrier;
				case "pickaxe":
					return BrCosmeticV1Type.Pickaxe;
				case "shout":
					return BrCosmeticV1Type.Shout;
				case "spray":
					return BrCosmeticV1Type.Spray;
				case "toy":
					return BrCosmeticV1Type.Toy;
				default:
					return BrCosmeticV1Type.Unknown;
			}
		}

		public static BrCosmeticV1Rarity GetBrCosmeticV1Rarity(string rarityString)
		{
			switch (rarityString)
			{
				case "uncommon":
					return BrCosmeticV1Rarity.Uncommon;
				case "common":
					return BrCosmeticV1Rarity.Common;
				case "rare":
					return BrCosmeticV1Rarity.Rare;
				case "epic":
					return BrCosmeticV1Rarity.Epic;
				case "legendary":
					return BrCosmeticV1Rarity.Legendary;
				case "mythic":
					return BrCosmeticV1Rarity.Mythic;
				case "slurp":
					return BrCosmeticV1Rarity.Slurp;
				case "shadow":
					return BrCosmeticV1Rarity.Shadow;
				case "marvel":
					return BrCosmeticV1Rarity.Marvel;
				case "lava":
					return BrCosmeticV1Rarity.Lava;
				case "frozen":
					return BrCosmeticV1Rarity.Frozen;
				case "dc":
					return BrCosmeticV1Rarity.DC;
				case "dark":
					return BrCosmeticV1Rarity.Dark;
				case "icon":
					return BrCosmeticV1Rarity.Icon;
				case "starwars":
					return BrCosmeticV1Rarity.StarWars;
				default:
					return BrCosmeticV1Rarity.Unknown;
			}
		}
	}
}