using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class MapV1Endpoint : EndpointBase
	{
		internal MapV1Endpoint(IRestClient client) : base(client) { }

		public async Task<ApiResponse<MapV1>> GetAsync(GameLanguage? language = null, CancellationToken token = default)
		{
			var request = new RestRequest("v1/map", Method.GET);

			if (language.HasValue)
			{
				request.AddQueryParameter("language", language.Value.GetLanguageCode());
			}

			var response = await _client.ExecuteAsync<ApiResponse<MapV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<MapV1> Get(GameLanguage? language = null)
		{
			return GetAsync(language).GetAwaiter().GetResult();
		}
	}
}