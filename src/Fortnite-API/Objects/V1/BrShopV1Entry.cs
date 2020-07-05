using System.Collections.Generic;

using J = Newtonsoft.Json.JsonPropertyAttribute;

namespace Fortnite_API.Objects.V1
{
	public class BrShopV1Entry
	{
		[J] public int RegularPrice { get; private set; }
		[J] public int FinalPrice { get; private set; }
		[J] public bool IsBundle { get; private set; }
		[J] public bool IsSpecial { get; private set; }
		[J] public bool Giftable { get; private set; }
		[J] public bool Refundable { get; private set; }
		[J] public int Panel { get; private set; }
		[J] public int SortPriority { get; private set; }
		[J] public string Banner { get; private set; }
		[J] public List<BrCosmeticV1> Items { get; private set; }
	}
}