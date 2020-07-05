using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class ShopV2Endpoints : EndpointBase
	{
		internal ShopV2Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<BrShopV2>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/shop/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrShopV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrShopV2> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrShopV2Combined>> GetBrCombinedAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/shop/br/combined", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrShopV2Combined>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrShopV2Combined> GetBrCombined(GameLanguage? language = null)
		{
			return GetBrCombinedAsync(language).GetAwaiter().GetResult();
		}
	}
}