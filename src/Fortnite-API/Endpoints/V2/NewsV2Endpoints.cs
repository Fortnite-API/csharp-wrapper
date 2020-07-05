using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class NewsV2Endpoints : EndpointBase
	{
		internal NewsV2Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<NewsV2Combined>> GetAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/news", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<NewsV2Combined>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<NewsV2Combined> Get(GameLanguage? language = null)
		{
			return GetAsync(language).GetAwaiter().GetResult();
		}

		private async Task<ApiResponse<NewsV2>> GetNewsAsync(IRestRequest request, GameLanguage? language, CancellationToken token)
		{
			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<NewsV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public Task<ApiResponse<NewsV2>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/news/br", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV2> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<NewsV2>> GetStwAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/news/stw", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV2> GetStw(GameLanguage? language = null)
		{
			return GetStwAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<NewsV2>> GetCreativeAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/news/creative", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV2> GetCreative(GameLanguage? language = null)
		{
			return GetCreativeAsync(language).GetAwaiter().GetResult();
		}
	}
}