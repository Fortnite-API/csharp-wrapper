using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class PlaylistsV1Endpoint : EndpointBase
	{
		internal PlaylistsV1Endpoint(IRestClient client) : base(client) { }

		public async Task<ApiResponse<List<PlaylistV1>>> GetAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/playlists", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<List<PlaylistV1>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<PlaylistV1>> Get(GameLanguage? language = null)
		{
			return GetAsync(language).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<PlaylistV1>> GetAsync(string playlistId, GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest($"v1/playlists/{playlistId}", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<PlaylistV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<PlaylistV1> Get(string playlistId, GameLanguage? language = null)
		{
			return GetAsync(playlistId, language).GetAwaiter().GetResult();
		}
	}
}