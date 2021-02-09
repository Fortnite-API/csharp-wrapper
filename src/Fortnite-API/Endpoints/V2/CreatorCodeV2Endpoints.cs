using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V2;

using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class CreatorCodeV2Endpoints : EndpointBase
	{
		internal CreatorCodeV2Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<CreatorCodeV2>> GetAsync(string name, CancellationToken token = default)
		{
			if (name == null)
			{
				throw new ArgumentNullException(nameof(name));
			}

			if (name.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(name));
			}

			var request = new RestRequest("v2/creatorcode", Method.GET).AddQueryParameter("name", name);

			var response = await _client.ExecuteAsync<ApiResponse<CreatorCodeV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCodeV2> Get(string name)
		{
			return GetAsync(name).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<CreatorCodeV2>> SearchAsync(string name, CancellationToken token = default)
		{
			if (name == null)
			{
				throw new ArgumentNullException(nameof(name));
			}

			if (name.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(name));
			}

			var request = new RestRequest("v2/creatorcode/search", Method.GET).AddQueryParameter("name", name);

			var response = await _client.ExecuteAsync<ApiResponse<CreatorCodeV2>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCodeV2> Search(string name)
		{
			return SearchAsync(name).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<CreatorCodeV2>>> SearchAllAsync(string name, CancellationToken token = default)
		{
			if (name == null)
			{
				throw new ArgumentNullException(nameof(name));
			}

			if (name.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(name));
			}

			var request = new RestRequest("v2/creatorcode/search/all", Method.GET).AddQueryParameter("name", name);

			var response = await _client.ExecuteAsync<ApiResponse<List<CreatorCodeV2>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<CreatorCodeV2>> SearchAll(string name)
		{
			return SearchAllAsync(name).GetAwaiter().GetResult();
		}
	}
}