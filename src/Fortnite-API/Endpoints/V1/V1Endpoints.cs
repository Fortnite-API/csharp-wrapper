using RestSharp;

namespace Fortnite_API.Endpoints.V1
{
	public class V1Endpoints
	{
		public CosmeticsV1Endpoints Cosmetics { get; }
		public ShopV1Endpoints Shop { get; }
		public NewsV1Endpoints News { get; }
		public CreatorcodeV1Endpoints CreatorCode { get; }
		public AesV1Endpoints Aes { get; }
		public StatsV1Endpoints Stats { get; }
		public PlaylistsV1Endpoint Playlists { get; }
		public MapV1Endpoint Map { get; }

		internal V1Endpoints(IRestClient client)
		{
			Cosmetics = new CosmeticsV1Endpoints(client);
			Shop = new ShopV1Endpoints(client);
			News = new NewsV1Endpoints(client);
			CreatorCode = new CreatorcodeV1Endpoints(client);
			Aes = new AesV1Endpoints(client);
			Stats = new StatsV1Endpoints(client);
			Playlists = new PlaylistsV1Endpoint(client);
			Map = new MapV1Endpoint(client);
		}
	}
}