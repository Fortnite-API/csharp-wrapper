using System;

using Fortnite_API.Endpoints.V1;
using Fortnite_API.Endpoints.V2;

using RestSharp;

namespace Fortnite_API
{
	public class FortniteApiClient
	{
		public V1Endpoints V1 { get; }
		public V2Endpoints V2 { get; }

		public FortniteApiClient(string apiKey = null)
		{
			var assemblyVersion = GetType().Assembly.GetName().Version;
			var versionString = assemblyVersion == null ? "unknown" : assemblyVersion.ToString(3);

			var client = new RestClient("https://fortnite-api.com/")
			{
				UserAgent = $"Fortnite-API.NET/{versionString}",
				Timeout = 10 * 1000
			}.UseSerializer<JsonNetSerializer>();

			if (!string.IsNullOrWhiteSpace(apiKey))
			{
				client.AddDefaultHeader("x-api-key", apiKey);
			}

			V1 = new V1Endpoints(client);
			V2 = new V2Endpoints(client);
		}
	}

	[Obsolete("Please use 'Fortnite_API.FortniteApiClient' instead", true)]
	public class FortniteApi
	{
		public V1Endpoints V1 { get; }
		public V2Endpoints V2 { get; }

		public FortniteApi(string apiKey = null)
		{
			V1 = null;
			V2 = null;
		}
	}
}