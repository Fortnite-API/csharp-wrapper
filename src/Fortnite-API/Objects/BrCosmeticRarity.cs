using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Fortnite_API.Objects
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrCosmeticRarity
	{
		[EnumMember(Value = "frozen")] Frozen,
		[EnumMember(Value = "lava")] Lava,
		[EnumMember(Value = "legendary")] Legendary,
		[EnumMember(Value = "dark")] Dark,
		[EnumMember(Value = "starwars")] StarWars,
		[EnumMember(Value = "marvel")] Marvel,
		[EnumMember(Value = "dc")] DC,
		[EnumMember(Value = "creatorcollab")] CreatorCollab,
		[EnumMember(Value = "shadow")] Shadow,
		[EnumMember(Value = "epic")] Epic,
		[EnumMember(Value = "rare")] Rare,
		[EnumMember(Value = "uncommon")] Uncommon,
		[EnumMember(Value = "common")] Common
	}
}