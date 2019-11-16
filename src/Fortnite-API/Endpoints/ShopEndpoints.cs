using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API.Endpoints
{
	public class ShopEndpoints
	{
		private readonly IRestClient _client;

		internal ShopEndpoints(IRestClient client)
		{
			_client = client;
		}

		public async Task<ApiResponse<BrShop>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/shop/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<BrShop>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrShop> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}
	}
}