using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class CreatorcodeV1Endpoints : EndpointBase
	{
		internal CreatorcodeV1Endpoints(IRestClient client) : base(client) { }

		public async Task<ApiResponse<CreatorCodeV1>> GetAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("v1/creatorcode", Method.GET).AddQueryParameter("slug", slug);

			var response = await _client.ExecuteAsync<ApiResponse<CreatorCodeV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCodeV1> Get(string slug)
		{
			return GetAsync(slug).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<CreatorCodeV1>> SearchAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("v1/creatorcode/search", Method.GET).AddQueryParameter("slug", slug);

			var response = await _client.ExecuteAsync<ApiResponse<CreatorCodeV1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCodeV1> Search(string slug)
		{
			return SearchAsync(slug).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<CreatorCodeV1>>> SearchAllAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("v1/creatorcode/search/all", Method.GET).AddQueryParameter("slug", slug);

			var response = await _client.ExecuteAsync<ApiResponse<List<CreatorCodeV1>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<CreatorCodeV1>> SearchAll(string slug)
		{
			return SearchAllAsync(slug).GetAwaiter().GetResult();
		}
	}
}