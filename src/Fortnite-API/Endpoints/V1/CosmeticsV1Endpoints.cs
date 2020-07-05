using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class CosmeticsV1Endpoints : EndpointBase
	{
		internal CosmeticsV1Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<List<BrCosmeticV1>>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/cosmetics/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV1>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV1>> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmeticV1>> GetBrAsync(string cosmeticId, GameLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticId == null)
			{
				throw new ArgumentNullException(nameof(cosmeticId));
			}

			if (cosmeticId.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(cosmeticId));
			}

			var request = new RestRequest($"v1/cosmetics/br/{cosmeticId}", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrCosmeticV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmeticV1> GetBr(string cosmeticId, GameLanguage? language = null)
		{
			return GetBrAsync(cosmeticId, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmeticV1>>> SearchBrIdsAsync(IEnumerable<string> cosmeticIds, GameLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticIds == null)
			{
				throw new ArgumentNullException(nameof(cosmeticIds));
			}

			var request = new RestRequest("v1/cosmetics/br/search/ids", Method.GET);
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

			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV1>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV1>> SearchBrIds(IEnumerable<string> cosmeticIds, GameLanguage? language = null)
		{
			return SearchBrIdsAsync(cosmeticIds, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmeticV1>> SearchBrAsync(Action<BrCosmeticV1SearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("v1/cosmetics/br/search", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteAsync<ApiResponse<BrCosmeticV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmeticV1> SearchBr(Action<BrCosmeticV1SearchProperties> func)
		{
			return SearchBrAsync(func).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmeticV1>>> SearchAllBrAsync(Action<BrCosmeticV1SearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("v1/cosmetics/br/search/all", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV1>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV1>> SearchAll(Action<BrCosmeticV1SearchProperties> func)
		{
			return SearchAllBrAsync(func).GetAwaiter().GetResult();
		}
	}
}