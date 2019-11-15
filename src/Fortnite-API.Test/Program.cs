using System.Diagnostics;
using System.Threading.Tasks;

using Fortnite_API.Objects;

namespace Fortnite_API.Test
{
	internal class Program
	{
		private static async Task Main()
		{
			var api = new FortniteApi();

			var cosmetics = await api.Cosmetics.GetBrAsync(ApiLanguage.DE);
			await Task.Delay(500);

			var johnWickById = await api.Cosmetics.GetBrAsync("bid_271_assassinsuitmale");
			await Task.Delay(500);

			var johnWick_ghoulTrooperSearch = await api.Cosmetics.SearchBrIdsAsync(new []
			{ 
				"bid_271_assassinsuitmale",
				"cid_029_athena_commando_f_halloween"
			});
			await Task.Delay(500);

			var johnWickSearch = await api.Cosmetics.SearchBrAsync(x =>
			{
				x.Name = "ohn wic";
				x.MatchMethod = MatchMethod.Contains;
			});
			await Task.Delay(500);

			var allShadowsSearch = await api.Cosmetics.SearchAllBrAsync(x =>
			{
				x.Rarity = BrCosmeticRarity.Shadow;
			});
			await Task.Delay(500);

			var shop = await api.Shop.GetBrAsync();
			await Task.Delay(500);

			var news = await api.News.GetAsync();
			await Task.Delay(500);

			var newsBr = await api.News.GetBrAsync();
			await Task.Delay(500);

			var newsStw = await api.News.GetStwAsync();
			await Task.Delay(500);

			var newsCreative = await api.News.GetCreativeAsync();

			Debugger.Break();
		}
	}
}