using System.Diagnostics;
using System.Threading.Tasks;

using Fortnite_API;
using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

namespace Fortnite_api.Test
{
	internal class Program
	{
		private static async Task Main()
		{
			const string apiKey = null; // optional as of now. check https://dash.fortnite-api.com to be sure
			var api = new FortniteApi(apiKey);

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