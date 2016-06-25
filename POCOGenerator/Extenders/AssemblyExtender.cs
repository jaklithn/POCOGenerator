using System;
using System.IO;
using System.Reflection;


namespace POCOGenerator.Extenders
{
	public static class AssemblyExtender
	{
		public static Version Version(this Assembly assembly)
		{
			return assembly.GetName().Version;
		}

		public static string DisplayVersion(this Assembly assembly)
		{
			var version = assembly.Version();
			return $"{version.Major}.{version.Minor} ({assembly.BuildDate().ToLocalTime().ToString("yyyy-MM-dd")})";
		}

		public static DateTime BuildDate(this Assembly assembly)
		{
			var filePath = assembly.Location;
			return GetTimestampFromLinker(filePath);
		}

		public static string Title(this Assembly assembly)
		{
			var attributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

			// If there is at least one Title attribute
			if (attributes.Length > 0)
			{
				// Select the first one
				var attribute = (AssemblyTitleAttribute)attributes[0];

				// If it is not an empty string, return it
				if (!string.IsNullOrEmpty(attribute.Title))
					return attribute.Title;
			}

			// Fallback is to return assembly name
			return assembly.GetName().Name;
		}

		public static string Product(this Assembly assembly)
		{
			var attributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);

			// If there is at least one Title attribute
			if (attributes.Length > 0)
			{
				// Select the first one
				var attribute = (AssemblyProductAttribute)attributes[0];
				return attribute.Product;
			}

			// Fallback
			return string.Empty;
		}

		public static string Copyright(this Assembly assembly)
		{
			var attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);

			// If there is at least one Title attribute
			if (attributes.Length > 0)
			{
				// Select the first one
				var attribute = (AssemblyCopyrightAttribute)attributes[0];
				return attribute.Copyright;
			}

			// Fallback
			return string.Empty;
		}

		/// <summary>
		/// Retrieves the linker timestamp from the file header.
		/// Code taken from here: http://www.codinghorror.com/blog/2005/04/determining-build-date-the-hard-way.html
		/// </summary>
		private static DateTime GetTimestampFromLinker(string filePath)
		{
			const int peHeaderOffset = 60;
			const int linkerTimestampOffset = 8;
			var baseDate = new DateTime(1970, 01, 01, 0, 0, 0);

			var b = new byte[2048];
			using (var s = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				s.Read(b, 0, 2048);
			}

			var timeInSeconds = BitConverter.ToInt32(b, BitConverter.ToInt32(b, peHeaderOffset) + linkerTimestampOffset);
			var dateTime = baseDate.AddSeconds(timeInSeconds);
			var dateTimeUtc = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);

			return dateTimeUtc;
		}

		/// <summary>
		/// Retrieve the assembly build date.
		/// Note: This will only work for assemblies where the Build and Revision of the Version is auto generated!
		/// Example: [assembly: AssemblyVersion("4.2.*")]
		/// </summary>
		private static DateTime GetTimestampFromVersion(this Assembly assembly)
		{
			var version = assembly.Version();
			return new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
		}
	}
}