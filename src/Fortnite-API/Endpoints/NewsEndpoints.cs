using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API.Endpoints
{
	public class NewsEndpoints
	{
		private readonly IRestClient _client;

		internal NewsEndpoints(IRestClient client)
		{
			_client = client;
		}

		public async Task<ApiResponse<CombinedNews>> GetAsync(ApiLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/news", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<CombinedNews>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CombinedNews> Get(ApiLanguage? language = null)
		{
			return GetAsync(language).GetAwaiter().GetResult();
		}

		private async Task<ApiResponse<News>> GetNewsAsync(IRestRequest request, ApiLanguage? language, CancellationToken token)
		{
			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<News>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public Task<ApiResponse<News>> GetBrAsync(ApiLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/news/br", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<News> GetBr(ApiLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<News>> GetStwAsync(ApiLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/news/stw", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<News> GetStw(ApiLanguage? language = null)
		{
			return GetStwAsync(language).GetAwaiter().GetResult();
		}

		public Task<ApiResponse<News>> GetCreativeAsync(ApiLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/news/creative", Method.GET);
			return GetNewsAsync(request, language, token);
		}

		public ApiResponse<News> GetCreative(ApiLanguage? language = null)
		{
			return GetCreativeAsync(language).GetAwaiter().GetResult();
		}
	}
}
