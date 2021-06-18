using Newtonsoft.Json;

using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Fortnite_API.Objects.V2
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	[JsonConverter(typeof(BrMaterialInstanceV2ColorConverter))]
	public readonly struct BrMaterialInstanceV2Color
	{
		public byte R { get; }
		public byte G { get; }
		public byte B { get; }
		public byte A { get; }

		internal BrMaterialInstanceV2Color(byte r, byte g, byte b, byte a)
		{
			R = r;
			G = g;
			B = b;
			A = a;
		}

		public override string ToString()
		{
			return $"{R:x2}{G:x2}{B:x2}{A:x2}";
		}
	}

	internal class BrMaterialInstanceV2ColorConverter : JsonConverter<BrMaterialInstanceV2Color>
	{
		public override void WriteJson(JsonWriter writer, BrMaterialInstanceV2Color value, JsonSerializer serializer)
		{
			writer.WriteValue(value.ToString());
		}

		public override BrMaterialInstanceV2Color ReadJson(JsonReader reader, Type objectType, BrMaterialInstanceV2Color existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.String)
			{
				return existingValue;
			}

			var value = (string)reader.Value;

			if (string.IsNullOrEmpty(value))
			{
				return existingValue;
			}

			var r = byte.Parse(value.Substring(0, 2), NumberStyles.HexNumber);
			var g = byte.Parse(value.Substring(2, 2), NumberStyles.HexNumber);
			var b = byte.Parse(value.Substring(4, 2), NumberStyles.HexNumber);
			var a = byte.Parse(value.Substring(6, 2), NumberStyles.HexNumber);
			return new BrMaterialInstanceV2Color(r, g, b, a);
		}
	}
}