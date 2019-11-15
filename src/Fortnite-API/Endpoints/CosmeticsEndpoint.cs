using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API.Endpoints
{
	public class CosmeticsEndpoints
	{
		private readonly IRestClient _client;

		internal CosmeticsEndpoints(IRestClient client)
		{
			_client = client;
		}

		public async Task<ApiResponse<List<BrCosmetic>>> GetBrAsync(ApiLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("/cosmetics/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<List<BrCosmetic>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmetic>> GetBr(ApiLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmetic>> GetBrAsync(string cosmeticId, ApiLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticId == null)
			{
				throw new ArgumentNullException(nameof(cosmeticId));
			}

			if (cosmeticId.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(cosmeticId));
			}

			var request = new RestRequest($"/cosmetics/br/{cosmeticId}", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<BrCosmetic>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmetic> GetBr(string cosmeticId, ApiLanguage? language = null)
		{
			return GetBrAsync(cosmeticId, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmetic>>> SearchBrIdsAsync(IEnumerable<string> cosmeticIds, ApiLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticIds == null)
			{
				throw new ArgumentNullException(nameof(cosmeticIds));
			}

			var request = new RestRequest("/cosmetics/br/search/ids", Method.GET);
			var isArrayEmpty = true;

			foreach (var cosmeticId in cosmeticIds)
			{
				isArrayEmpty = false;
				request.AddQueryParameter("id", cosmeticId);
			}

			if (isArrayEmpty)
			{
				throw new ArgumentOutOfRangeException(nameof(cosmeticIds));
			}

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteTaskAsync<ApiResponse<List<BrCosmetic>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmetic>> SearchBrIds(IEnumerable<string> cosmeticIds, ApiLanguage? language = null)
		{
			return SearchBrIdsAsync(cosmeticIds, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmetic>> SearchBrAsync(Action<BrCosmeticSearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("/cosmetics/br/search", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteTaskAsync<ApiResponse<BrCosmetic>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmetic> SearchBr(Action<BrCosmeticSearchProperties> func)
		{
			return SearchBrAsync(func).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmetic>>> SearchAllBrAsync(Action<BrCosmeticSearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("/cosmetics/br/search/all", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteTaskAsync<ApiResponse<List<BrCosmetic>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmetic>> SearchAll(Action<BrCosmeticSearchProperties> func)
		{
			return SearchAllBrAsync(func).GetAwaiter().GetResult();
		}
	}
}