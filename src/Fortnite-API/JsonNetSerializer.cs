using Newtonsoft.Json;

using RestSharp;
using RestSharp.Serialization;

namespace Fortnite_API
{
	internal class JsonNetSerializer : IRestSerializer
	{
		public string Serialize(object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}

		public string Serialize(Parameter parameter)
		{
			return JsonConvert.SerializeObject(parameter.Value);
		}

		public T Deserialize<T>(IRestResponse response)
		{
			return JsonConvert.DeserializeObject<T>(response.Content);
		}

		public string[] SupportedContentTypes { get; } =
		{
			"application/json",
			"application/json; charset=utf-8"
		};

		public string ContentType { get; set; } = "application/json; charset=utf-8";

		public DataFormat DataFormat { get; } = DataFormat.Json;
	}
}