using System.Diagnostics;

using J = Newtonsoft.Json.JsonPropertyAttribute;
using I = Newtonsoft.Json.JsonPropertyAttribute;
using N = Newtonsoft.Json.NullValueHandling;

namespace Fortnite_API.Objects
{
	[DebuggerDisplay("{" + nameof(DebuggerDisplay) + "}")]
	public class ApiResponse<T>
	{
		[J] public int Status { get; private set; }
		[J(NullValueHandling = N.Ignore)] public T Data { get; private set; }
		[J(NullValueHandling = N.Ignore)] public string Error { get; private set; }

		[I] public bool IsSuccess => Status == 200;
		[I] public bool HasError => Error != null;

		private object DebuggerDisplay => IsSuccess ? Data : (object)$"Error: {Status} | {Error}";
	}
}