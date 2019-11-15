using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Fortnite_API.Objects
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrCosmeticType
	{
		[EnumMember(Value = "banner")] Banner,
		[EnumMember(Value = "backpack")] Backpack,
		[EnumMember(Value = "contrail")] Contrail,
		[EnumMember(Value = "outfit")] Outfit,
		[EnumMember(Value = "emote")] Emote,
		[EnumMember(Value = "emoji")] Emoji,
		[EnumMember(Value = "glider")] Glider,
		[EnumMember(Value = "wrap")] Wrap,
		[EnumMember(Value = "loadingscreen")] LoadingScreen,
		[EnumMember(Value = "music")] Music,
		[EnumMember(Value = "pet")] Pet,
		[EnumMember(Value = "pickaxe")] Pickaxe,
		[EnumMember(Value = "spray")] Spray,
		[EnumMember(Value = "toy")] Toy
	}
}