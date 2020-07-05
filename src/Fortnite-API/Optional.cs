using System.Diagnostics;

namespace Fortnite_API
{
	[DebuggerDisplay("{" + nameof(DebuggerDisplay) + @",nq}")]
	public readonly struct Optional<T>
	{
		private readonly T _value;

		public T Value => HasValue ? _value : default;

		public readonly bool HasValue;

		public Optional(T value)
		{
			_value = value;
			HasValue = true;
		}

		public override bool Equals(object other)
		{
			if (!HasValue)
			{
				return other == null;
			}

			return other != null && _value.Equals(other);
		}

		public override int GetHashCode()
		{
			return HasValue ? _value.GetHashCode() : 0;
		}

		public override string ToString()
		{
			return HasValue ? _value?.ToString() : null;
		}

		private string DebuggerDisplay => HasValue ? _value?.ToString() ?? "<null>" : "<unspecified>";

		public static implicit operator Optional<T>(T value)
		{
			return new Optional<T>(value);
		}

		public static explicit operator T(Optional<T> value)
		{
			return value.Value;
		}
	}
}