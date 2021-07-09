using RestSharp;

namespace Fortnite_API.Endpoints.V2
{
	public class V2Endpoints
	{
		public CosmeticsV2Endpoints Cosmetics { get; }
		public AesV2Endpoints Aes { get; }
		public NewsV2Endpoints News { get; }
		public CreatorCodeV2Endpoints CreatorCode { get; }
		public ShopV2Endpoints Shop { get; }
		public StatsV2Endpoints Stats { get; }

		internal V2Endpoints(IRestClient client)
		{
			Cosmetics = new CosmeticsV2Endpoints(client);
			Aes = new AesV2Endpoints(client);
			News = new NewsV2Endpoints(client);
			CreatorCode = new CreatorCodeV2Endpoints(client);
			Shop = new ShopV2Endpoints(client);
			Stats = new StatsV2Endpoints(client);
		}
	}
}