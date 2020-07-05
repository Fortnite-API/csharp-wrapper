using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrShopV1Entry
	{
		[J("regularPrice")] public int RegularPrice { get; private set; }
		[J("finalPrice")] public int FinalPrice { get; private set; }
		[J("isBundle")] public bool IsBundle { get; private set; }
		[J("isSpecial")] public bool IsSpecial { get; private set; }
		[J("giftable")] public bool Giftable { get; private set; }
		[J("refundable")] public bool Refundable { get; private set; }
		[J("panel")] public int Panel { get; private set; }
		[J("sortPriority")] public int SortPriority { get; private set; }
		[J("banner")] public string Banner { get; private set; }
		[J("items")] public List<BrCosmeticV1> Items { get; private set; }
	}
}