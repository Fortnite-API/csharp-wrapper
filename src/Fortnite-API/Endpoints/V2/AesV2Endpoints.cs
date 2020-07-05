using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class AesV2Endpoints : EndpointBase
	{
		internal AesV2Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<AesV2>> GetAsync(AesV2KeyFormat? keyFormat = null, CancellationToken token = default)
		{
			var request = new RestRequest("v2/aes", Method.GET);

			if (keyFormat.HasValue)
			{
				request.AddQueryParameter("keyFormat", keyFormat.Value.GetString());
			}

			var response = await _client.ExecuteAsync<ApiResponse<AesV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<AesV2> Get(AesV2KeyFormat? keyFormat = null)
		{
			return GetAsync(keyFormat).GetAwaiter().GetResult();
		}
	}
}