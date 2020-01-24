using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API.Endpoints
{
	public class AesEndpoint
	{
		private readonly IRestClient _client;

		internal AesEndpoint(IRestClient client)
		{
			_client = client;
		}

		public async Task<ApiResponse<AesData>> GetAsync(CancellationToken token = default)
		{
			var request = new RestRequest("aes", Method.GET);
			var response = await _client.ExecuteTaskAsync<ApiResponse<AesData>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<AesData> Get()
		{
			return GetAsync().GetAwaiter().GetResult();
		}
	}
}