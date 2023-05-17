using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer
{
    public class SqlDB
    {
		public static string ApplicationName { get; set; }
		public static bool Pooling { get; set; } = true;
		public static string Desc { get; set; }
		public static string GetConnectionString(string keyofConnString)
		{
			string connStr = System.Configuration.ConfigurationManager.ConnectionStrings[keyofConnString].ToString();

			if (string.IsNullOrEmpty(connStr))
			{
				throw new Exception("找不到連線字串, key = " + keyofConnString);
			}

			SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(connStr);
			sb.Pooling = Pooling;
			
			if(string.IsNullOrEmpty(ApplicationName) == false )
			{
				sb.ApplicationName = ApplicationName;
			}

			return sb.ToString();
		}
		public static SqlConnection GetConnection(string keyofConnString = "default")
		{
			string connStr = GetConnectionString(keyofConnString);
			return new SqlConnection(connStr);
		}
		public static SqlConnection GetConnection()
		{
			return GetConnection("default");
		}
		public static int UpdateOrDelete(Func<SqlConnection> funConn, string sql, params SqlParameter[] parameters)
		{
			using (var conn = funConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null)
					{
						cmd.Parameters.AddRange(parameters);
						return cmd.ExecuteNonQuery(); //傳回被異動的筆數
					}
					return 0;
				}
			}
		}
		public static int Create(Func<SqlConnection> funConn, string sql, params SqlParameter[] parameters)
		{
			sql += ";SELECT SCOPE_IDENTITY()";

			using (var conn = funConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					//return (int)cmd.Parameters["@newId"].Value;
					return Convert.ToInt32(cmd.ExecuteScalar());
				}
			}
		}
		public static T Get<T>(Func<SqlConnection> funConn,
								Func<SqlDataReader, T> funcAssembler,
								string sql,
								params SqlParameter[] parameters)
		{
			using (var conn = funConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
					return reader.Read()
						? funcAssembler(reader)
						: default(T);
				}
			}
		}
		public static List<T> Search<T>(Func<SqlConnection> funConn,
										Func<SqlDataReader, T> funcAssembler,
										string sql,
										params SqlParameter[] parameters)
		{
			List<T> list = new List<T>();
			if (Desc != null)
			{
				sql += Desc;
			}

			using (var conn = funConn())
			{
				conn.Open();
				using (var cmd = new SqlCommand(sql, conn))
				{
					if (parameters != null) cmd.Parameters.AddRange(parameters);

					var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

					while (reader.Read())
					{
						T entity = funcAssembler(reader);
						list.Add(entity);
					}
					return list;
				}
			}
		}
	}
}
