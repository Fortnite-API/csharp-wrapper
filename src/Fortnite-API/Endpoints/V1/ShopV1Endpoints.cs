using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class ShopV1Endpoints : EndpointBase
	{
		internal ShopV1Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<BrShopV1>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/shop/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrShopV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrShopV1> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}
	}
}