using RestSharp;

namespace Fortnite_API.Endpoints
{
	public abstract class EndpointBase
	{
		internal readonly IRestClient _client;

		internal EndpointBase(IRestClient client)
		{
			_client = client;
		}
	}
}