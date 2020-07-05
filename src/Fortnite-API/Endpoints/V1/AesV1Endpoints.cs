using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class AesV1Endpoints : EndpointBase
	{
		internal AesV1Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<AesV1>> GetAsync(CancellationToken token = default)
		{
			var request = new RestRequest("v1/aes", Method.GET);
			var response = await _client.ExecuteAsync<ApiResponse<AesV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<AesV1> Get()
		{
			return GetAsync().GetAwaiter().GetResult();
		}
	}
}