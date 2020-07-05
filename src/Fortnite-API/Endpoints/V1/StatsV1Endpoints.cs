using System;
using System.Threading;
using System.Threading.Tasks;

using Fortnite_API.Objects;
using Fortnite_API.Objects.V1;

using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class StatsV1Endpoints : EndpointBase
	{
		internal StatsV1Endpoints(IRestClient client) : base(client) { }

		[Obsolete("BR V1 stats are no longer available since Epic Games shut down the endpoint.", true)]
		public Task GetBrV1Async()
		{
			return Task.Delay(1); // net452 doesnt have Task.CompletedTask
		}

		[Obsolete("BR V1 stats are no longer available since Epic Games shut down the endpoint.", true)]
		public void GetBrV1() { }

		public async Task<ApiResponse<BrStatsV2V1>> GetBrV2Async(Action<BrStatsV2V1RequestProperties> func, CancellationToken token = default)
		{
			var props = new BrStatsV2V1RequestProperties();
			func(props);

			RestRequest request;

			if (props.AccountId.HasValue)
			{
				request = new RestRequest($"v1/stats/br/v2/{props.AccountId.Value}", Method.GET);
			}
			else if (props.Name.HasValue)
			{
				request = new RestRequest("v1/stats/br/v2", Method.GET);
				request.AddQueryParameter("name", props.Name.Value);

				if (props.AccountType.HasValue)
				{
					request.AddQueryParameter("accountType", props.AccountType.Value.GetString());
				}
			}
			else
			{
				throw new ArgumentException("missing accountId or name");
			}

			if (props.TimeWindow.HasValue)
			{
				request.AddQueryParameter("timeWindow", props.TimeWindow.Value.GetString());
			}

			if (props.ImagePlatform.HasValue)
			{
				request.AddQueryParameter("image", props.ImagePlatform.Value.GetString());
			}

			var response = await _client.ExecuteAsync<ApiResponse<BrStatsV2V1>>(request, token).ConfigureAwait(false);
			return response.Data;
		}

		public ApiResponse<BrStatsV2V1> GetBrV2Id(Action<BrStatsV2V1RequestProperties> func)
		{
			return GetBrV2Async(func).GetAwaiter().GetResult();
		}
	}
}