using System;
using System.Reflection;

using Fortnite_API.Endpoints.V1;
using Fortnite_API.Endpoints.V2;

using RestSharp;

namespace Fortnite_API
{
	public class FortniteApi
	{
		public V1Endpoints V1 { get; }
		public V2Endpoints V2 { get; }

		public FortniteApi(string apiKey = null)
		{
			var client = new RestClient(new Uri("https://fortnite-api.com"))
			{
				UserAgent = $"Fortnite-API.NET/{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}",
				Timeout = 10 * 1000
			}.UseSerializer<JsonNetSerializer>();

			if (!string.IsNullOrWhiteSpace(apiKey))
			{
				client.DefaultParameters.Add(new Parameter("x-api-key", apiKey, ParameterType.HttpHeader));
			}

			V1 = new V1Endpoints(client);
			V2 = new V2Endpoints(client);
		}
	}
}