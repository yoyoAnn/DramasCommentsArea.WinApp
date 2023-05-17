using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer
{
	public static class SqlDataReaderExtensions
	{
		public static string GetString(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? null
				: reader.GetString(colIndex);
		}
		public static byte GetByte(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.GetByte(colIndex);
		}

		//public static byte? GetByte(this SqlDataReader reader, string columnName)
		//{
		//	int colIndex = reader.GetOrdinal(columnName);
		//	return reader.IsDBNull(colIndex)
		//		? (byte?)null
		//		: reader.GetByte(colIndex);
		//}
		//public static byte GetByte(this SqlDataReader reader, string columnName, byte defaultValue)
		//{
		//	byte? result = reader.GetByte(columnName);
		//	return result.HasValue
		//		? result.Value
		//		: defaultValue;
		//}
		public static int? GetInt32(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (int?)null
				: reader.GetInt32(colIndex);
		}
		public static int GetInt32(this SqlDataReader reader, string columnName, int defaultValue)
		{
			int? result = reader.GetInt32(columnName);
			return result.HasValue
				? result.Value
				: defaultValue;
		}
		public static DateTime? GetDateTime(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.IsDBNull(colIndex)
				? (DateTime?)null
				: reader.GetDateTime(colIndex);
		}
		public static DateTime GetDate(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.GetDateTime(colIndex).Date;
		}

		public static DateTime GetDateTime(this SqlDataReader reader, string columnName, DateTime defaultValue)
		{
			DateTime? result = reader.GetDateTime(columnName);
			return result.HasValue ? result.Value : defaultValue;
		}
		public static bool GetBoolean(this SqlDataReader reader, string columnName)
		{
			int colIndex = reader.GetOrdinal(columnName);
			return reader.GetBoolean(colIndex);
		}
	}
}
