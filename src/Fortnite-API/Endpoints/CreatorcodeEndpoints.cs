using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;

using RestSharp;

namespace Fortnite_API.Endpoints
{
	public class CreatorcodeEndpoints
	{
		private readonly IRestClient _client;

		internal CreatorcodeEndpoints(IRestClient client)
		{
			_client = client;
		}

		public async Task<ApiResponse<CreatorCode>> GetAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("/creatorcode", Method.GET)
			{
				Parameters =
				{
					new Parameter("slug", slug, ParameterType.QueryString)
				}
			};

			var response = await _client.ExecuteTaskAsync<ApiResponse<CreatorCode>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCode> Get(string slug)
		{
			return GetAsync(slug).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<CreatorCode>> SearchAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("/creatorcode/search", Method.GET)
			{
				Parameters =
				{
					new Parameter("slug", slug, ParameterType.QueryString)
				}
			};

			var response = await _client.ExecuteTaskAsync<ApiResponse<CreatorCode>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<CreatorCode> Search(string slug)
		{
			return SearchAsync(slug).GetAwaiter().GetResult();
		}

		public async Task<ApiResponse<List<CreatorCode>>> SearchAllAsync(string slug, CancellationToken token = default)
		{
			if (slug == null)
			{
				throw new ArgumentNullException(nameof(slug));
			}

			if (slug.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(slug));
			}

			var request = new RestRequest("/creatorcode/search/all", Method.GET)
			{
				Parameters =
				{
					new Parameter("slug", slug, ParameterType.QueryString)
				}
			};

			var response = await _client.ExecuteTaskAsync<ApiResponse<List<CreatorCode>>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<List<CreatorCode>> SearchAll(string slug)
		{
			return SearchAllAsync(slug).GetAwaiter().GetResult();
		}
	}
}