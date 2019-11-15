using System;
using System.Collections.Generic;
using System.Text;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects
{
	public class CombinedNews
	{
		[J("br")] public News Br;
		[J("stw")] public News Stw;
		[J("creative")] public News Creative;
	}
}
