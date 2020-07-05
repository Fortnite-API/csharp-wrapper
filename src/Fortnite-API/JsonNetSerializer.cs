using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using RestSharp;
using RestSharp.Serialization;

namespace Fortnite_API
{
	internal class JsonNetSerializer : IRestSerializer
	{
		private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
		{
			ContractResolver = new CamelCasePropertyNamesContractResolver()
		};

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
			return JsonConvert.DeserializeObject<T>(response.Content, _serializerSettings);
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