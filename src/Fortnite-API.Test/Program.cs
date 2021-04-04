using System.Diagnostics;
using System.Threading.Tasks;

using Fortnite_API;

namespace Fortnite_api.Test
{
	internal class Program
	{
		private static async Task Main()
		{
			var apiKey = string.Empty; // optional as of now. check https://dash.fortnite-api.com to be sure
			var api = new FortniteApiClient(apiKey);

			var pak1002Cosmetics = await api.V2.Cosmetics.SearchAllBrAsync(x => x.DynamicPakId = "1002");
			var s16Cosmetics = await api.V2.Cosmetics.SearchAllBrAsync(x => x.BackendIntroduction = 16);
			//var newCosmetics = await api.V2.Cosmetics.GetBrNewAsync();
			//var map = await api.V1.Map.GetAsync();

			//var cosmeticsV2 = await api.V2.Cosmetics.GetBrAsync();
			//var renegadeSearch = await api.V2.Cosmetics.SearchBrAsync(x =>
			//{
			//	x.Name = "enegade raid";
			//	x.MatchMethod = MatchMethod.Contains;
			//	x.BackendType = "AthenaCharacter";
			//});

			//var aesV2 = await api.V2.Aes.GetAsync();
			//var aesV2Base64 = await api.V2.Aes.GetAsync(AesV2KeyFormat.Base64);

			//var newsV2 = await api.V2.News.GetAsync();
			//var newsV2German = await api.V2.News.GetAsync(GameLanguage.DE);
			//var newsV2Br = await api.V2.News.GetBrAsync();

			//var creatorCodeV2tfue = await api.V2.CreatorCode.GetAsync("tfue239042039480");
			//var creatorCodeV2allStw = await api.V2.CreatorCode.SearchAllAsync("stw");

			//var shopV2 = await api.V2.Shop.GetBrAsync();
			//var shopV2German = await api.V2.Shop.GetBrAsync(GameLanguage.DE);
			//var shopV2Combined = await api.V2.Shop.GetBrCombinedAsync();

			//var statsV2V1 = await api.V1.Stats.GetBrV2Async(x =>
			//{
			//	//x.AccountId = "4735ce9132924caf8a5b17789b40f79c";
			//	x.Name = "ninja";
			//	x.ImagePlatform = BrStatsV2V1ImagePlatform.All;
			//});

			Debugger.Break();
		}
	}
}