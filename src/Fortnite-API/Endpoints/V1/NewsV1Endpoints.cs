using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class NewsV1Endpoints : EndpointBase
	{
		internal NewsV1Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<CombinedNewsV1>> GetAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/news", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<CombinedNewsV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CombinedNewsV1> Get(GameLanguage? language = null)
		{
			return GetAsync(language).GetAwaiter().GetResult();
		}

		private async Task<ApiResponse<NewsV1>> GetNewsAsync(IRestRequest request, GameLanguage? language, CancellationToken token)
		{
			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<NewsV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public Task<ApiResponse<NewsV1>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/news/br", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV1> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<NewsV1>> GetStwAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/news/stw", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV1> GetStw(GameLanguage? language = null)
		{
			return GetStwAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<NewsV1>> GetCreativeAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/news/creative", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<NewsV1> GetCreative(GameLanguage? language = null)
		{
			return GetCreativeAsync(language).GetAwaiter().GetResult();
		}
	}
}