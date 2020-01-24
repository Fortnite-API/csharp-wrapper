﻿using System;
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
		public CreatorcodeEndpoints CreatorCode { get; }
		public AesEndpoint Aes { get; }

		public FortniteApi(string apiKey)
		{
			if (apiKey == null)
			{
				throw new ArgumentNullException(nameof(apiKey));
			}

			if (apiKey.Length == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(apiKey));
			}

			var _client = new RestClient("https://fortnite-api.com/")
			{
				UserAgent = $"Fortnite-API.NET/{Assembly.GetExecutingAssembly().GetName().Version.ToString(3)}",
				Timeout = 10 * 1000,
				DefaultParameters =
				{
					new Parameter("x-api-key", apiKey, ParameterType.HttpHeader)
				}
			}.UseSerializer<JsonNetSerializer>();

			Cosmetics = new CosmeticsEndpoints(_client);
			Shop = new ShopEndpoints(_client);
			News = new NewsEndpoints(_client);
			CreatorCode = new CreatorcodeEndpoints(_client);
			Aes = new AesEndpoint(_client);
		}
	}
}