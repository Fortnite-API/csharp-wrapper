﻿using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class V1Endpoints
	{
		public CosmeticsV1Endpoints Cosmetics { get; }
		public ShopV1Endpoints Shop { get; }
		public NewsV1Endpoints News { get; }
		public CreatorcodeV1Endpoints CreatorCode { get; }
		public AesV1Endpoints Aes { get; }

		internal V1Endpoints(IRestClient client)
		{
			Cosmetics = new CosmeticsV1Endpoints(client);
			Shop = new ShopV1Endpoints(client);
			News = new NewsV1Endpoints(client);
			CreatorCode = new CreatorcodeV1Endpoints(client);
			Aes = new AesV1Endpoints(client);
		}
	}
}