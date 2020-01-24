using I = Newtonsoft.Json.JsonIgnoreAttribute;
using J = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace Fortnite_API.Objects
{
	public class ApiResponse<T>
	{
		[J("status")] public int Status { get; private set; }
		[J("data", NullValueHandling = N.Ignore)] public T Data { get; private set; }
		[J("error", NullValueHandling = N.Ignore)] public string Error { get; private set; }

		[I]public bool IsSuccess => Status == 200;
		[I]public bool HasError => Error != null;
	}
}