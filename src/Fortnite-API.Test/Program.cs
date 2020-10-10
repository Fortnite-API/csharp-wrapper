using System.Diagnostics;
using System.Threading.Tasks;

using Fortnite_API;
using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;
using Fortnite_API.Objects.V2;

namespace Fortnite_api.Test
{
	internal class Program
	{
		private static async Task Main()
		{
			const string apiKey = null; // optional as of now. check https://dash.fortnite-api.com to be sure
			var api = new FortniteApi(apiKey);

			var playlistsV1 = await api.V1.Playlists.GetAsync();
			var playlistSoloV1 = await api.V1.Playlists.GetAsync("playlist_defaultsolo");

			Debugger.Break();
			return;

			//var cosmeticsV2 = await api.V2.Cosmetics.GetBrAsync();
			var renegadeSearch = await api.V2.Cosmetics.SearchBrAsync(x =>
			{
				x.Name = "enegade raid";
				x.MatchMethod = MatchMethod.Contains;
				x.BackendType = "AthenaCharacter";
			});

			var aesV2 = await api.V2.Aes.GetAsync();
			var aesV2Base64 = await api.V2.Aes.GetAsync(AesV2KeyFormat.Base64);

			var newsV2 = await api.V2.News.GetAsync();
			var newsV2German = await api.V2.News.GetAsync(GameLanguage.DE);
			var newsV2Br = await api.V2.News.GetBrAsync();

			var creatorCodeV2tfue = await api.V2.CreatorCode.GetAsync("tfue239042039480");
			var creatorCodeV2allStw = await api.V2.CreatorCode.SearchAllAsync("stw");

			var shopV2 = await api.V2.Shop.GetBrAsync();
			var shopV2German = await api.V2.Shop.GetBrAsync(GameLanguage.DE);
			var shopV2Combined = await api.V2.Shop.GetBrCombinedAsync();

			var statsV2V1 = await api.V1.Stats.GetBrV2Async(x =>
			{
				//x.AccountId = "4735ce9132924caf8a5b17789b40f79c";
				x.Name = "ninja";
				x.ImagePlatform = BrStatsV2V1ImagePlatform.All;
			});

			var aes = await api.V1.Aes.GetAsync();
			await Task.Delay(500);
			var tfueCode = await api.V1.CreatorCode.GetAsync("tfue");
			await Task.Delay(500);
			var searchTestCode = await api.V1.CreatorCode.SearchAsync("test");
			await Task.Delay(500);
			var searchAllTestCode = await api.V1.CreatorCode.SearchAllAsync("test");
			await Task.Delay(500);

			var cosmetics = await api.V1.Cosmetics.GetBrAsync(GameLanguage.DE);
			await Task.Delay(500);

			var johnWickById = await api.V1.Cosmetics.GetBrAsync("bid_271_assassinsuitmale");
			await Task.Delay(500);

			var johnWick_ghoulTrooperSearch = await api.V1.Cosmetics.SearchBrIdsAsync(new []
			{ 
				"bid_271_assassinsuitmale",
				"cid_029_athena_commando_f_halloween"
			});
			await Task.Delay(500);

			var johnWickSearch = await api.V1.Cosmetics.SearchBrAsync(x =>
			{
				x.Name = "ohn wic";
				x.MatchMethod = MatchMethod.Contains;
			});
			await Task.Delay(500);

			var allIconSeriesSearch = await api.V1.Cosmetics.SearchAllBrAsync(x =>
			{
				x.Rarity = BrCosmeticV1Rarity.Icon;
			});
			await Task.Delay(500);

			var shop = await api.V1.Shop.GetBrAsync();
			await Task.Delay(500);

			var news = await api.V1.News.GetAsync();
			await Task.Delay(500);

			var newsBr = await api.V1.News.GetBrAsync();
			await Task.Delay(500);

			var newsStw = await api.V1.News.GetStwAsync();
			await Task.Delay(500);

			var newsCreative = await api.V1.News.GetCreativeAsync();

			Debugger.Break();
		}
	}
}