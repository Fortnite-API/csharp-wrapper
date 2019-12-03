using System.Reflection;

using Fortnite_API.Endpoints;

using RestSharp;

namespace Fortnite_API
{
	public class FortniteApi
	{
		//private readonly IRestClient _client;
		public CosmeticsEndpoints Cosmetics { get; }
		public ShopEndpoints Shop { get; }
		public NewsEndpoints News { get; }

		public FortniteApi(string apiKey = null)
		{
			var currentVersion = Assembly.GetExecutingAssembly().GetName().Version;
			var _client = new RestClient("https://fortnite-api.com/")
			{
				UserAgent = $"Fortnite-API.NET/{currentVersion.ToString(3)}",
				Timeout = 10 * 1000
			}.UseSerializer<JsonNetSerializer>();

			if (!string.IsNullOrWhiteSpace(apiKey))
			{
				_client.DefaultParameters.Add(new Parameter("x-api-key", apiKey, ParameterType.HttpHeader));
			}

			Cosmetics = new CosmeticsEndpoints(_client);
			Shop = new ShopEndpoints(_client);
			News = new NewsEndpoints(_client);
		}
	}
}