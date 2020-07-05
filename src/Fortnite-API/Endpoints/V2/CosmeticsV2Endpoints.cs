using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class CosmeticsV2Endpoints : EndpointBase
	{
		internal CosmeticsV2Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<List<BrCosmeticV2>>> GetBrAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/cosmetics/br", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV2>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV2>> GetBr(GameLanguage? language = null)
		{
			return GetBrAsync(language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmeticV2>> GetBrAsync(string cosmeticId, GameLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticId == null)
			{
				throw new ArgumentNullException(nameof(cosmeticId));
			}

			if (cosmeticId.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(cosmeticId));
			}

			var request = new RestRequest($"v2/cosmetics/br/{cosmeticId}", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrCosmeticV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmeticV2> GetBr(string cosmeticId, GameLanguage? language = null)
		{
			return GetBrAsync(cosmeticId, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmeticV2>>> SearchBrIdsAsync(IEnumerable<string> cosmeticIds, GameLanguage? language = null, CancellationToken token = default)
		{
			if (cosmeticIds == null)
			{
				throw new ArgumentNullException(nameof(cosmeticIds));
			}

			var request = new RestRequest("v2/cosmetics/br/search/ids", Method.GET);
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

			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV2>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV2>> SearchBrIds(IEnumerable<string> cosmeticIds, GameLanguage? language = null)
		{
			return SearchBrIdsAsync(cosmeticIds, language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<BrCosmeticV2>> SearchBrAsync(Action<BrCosmeticV2SearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("v2/cosmetics/br/search", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteAsync<ApiResponse<BrCosmeticV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrCosmeticV2> SearchBr(Action<BrCosmeticV2SearchProperties> func)
		{
			return SearchBrAsync(func).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<BrCosmeticV2>>> SearchAllBrAsync(Action<BrCosmeticV2SearchProperties> func, CancellationToken token = default)
		{
			if (func == null)
			{
				throw new ArgumentNullException(nameof(func));
			}

			var request = new RestRequest("v2/cosmetics/br/search/all", Method.GET).ApplySearchParameters(func);
			var response = await _client.ExecuteAsync<ApiResponse<List<BrCosmeticV2>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<BrCosmeticV2>> SearchAll(Action<BrCosmeticV2SearchProperties> func)
		{
			return SearchAllBrAsync(func).GetAwaiter().GetResult();
		}
	}
}