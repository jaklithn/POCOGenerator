using System;


namespace POCOGenerator.Extenders
{
	public static class StringExtender
	{
		public static string ToUpperFirst(this string value)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;
			var a = value.ToCharArray();
			a[0] = char.ToUpper(a[0]);
			return new string(a);
		}

		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		public static bool IsSpecified(this string value)
		{
			return !string.IsNullOrEmpty(value);
		}

		/// <summary>
		/// Parse string into specified enum type and make sure it matches a valid enum value.
		/// </summary>
		public static T ToEnum<T>(this string value)
		{
			if (!Enum.IsDefined(typeof(T), value))
				throw new Exception(string.Format("String value='{0}' can not be interpreted as valid enum of type {1}", value, typeof(T).Name));

			return (T)Enum.Parse(typeof(T), value);
		}
	}
}