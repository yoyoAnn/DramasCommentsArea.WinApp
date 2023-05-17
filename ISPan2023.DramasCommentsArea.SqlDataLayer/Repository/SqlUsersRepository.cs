using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Repository
{
	public class SqlUsersRepository : IUsersRepository
	{
		public void Create(UsersEntity entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(int usersId)
		{
			throw new NotImplementedException();
		}

		public UsersEntity Get(int usersId)
		{
			string sql = "SELECT * FROM users WHERE id = " + usersId;

			Func<SqlDataReader, UsersEntity> funcAssembler = reader =>
			{
				UsersEditDto dto = new UsersEditDto
				{
					Id = reader.GetInt32("id", 0),
					Account = reader.GetString("account"),
					Password = reader.GetString("password"),
					Gender = reader.GetBoolean("gender"),
					Birthday = reader.GetDate("birthday").Date,
					Mail = reader.GetString("mail"),
					CreatedTime = reader.GetDateTime("createdTime", default)
				};
				return new UsersEntity(dto);
			};
			return SqlDB.Get(SqlDB.GetConnection, funcAssembler, sql, null);
		}

		public List<UsersEntity> Search(int commentsNum, string usersAccount = null, string sortName = null)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			//string sql = @"SELECT * FROM users";
			string sql = @"SELECT users.id, account, password, gender, birthday, mail, users.createdTime, COUNT(*) AS '評論數'
FROM users
LEFT JOIN comments on users.id = fk_usersId
GROUP BY users.id, account, password, gender, birthday, mail, users.createdTime";

			#region 組合出 having 條件
			string having = string.Empty;
			if (string.IsNullOrEmpty(usersAccount) == false)
			{
				having += $" AND account LIKE '%{usersAccount}%'";
			}
			if(commentsNum != 0)
			{
				having += $" AND COUNT(*) >= {commentsNum}";
			}
			sql += string.IsNullOrEmpty(having) ? string.Empty : " HAVING " + having.Substring(5);
			#endregion

			#region 組合出 order by 條件
			if (string.IsNullOrEmpty(sortName) == false)
			{
				sql += $" ORDER BY {sortName}";
			}
			else
			{
				sql += " ORDER BY users.id";
			}
			#endregion

			Func<SqlDataReader, UsersEntity> funcAssembler = reader =>
			{
				UsersDto dto = new UsersDto
				{
					Id = reader.GetInt32("id", 0),
					Account = reader.GetString("account"),
					Password = reader.GetString("password"),
					Gender = reader.GetBoolean("gender"),
					Birthday = reader.GetDate("birthday").Date,
					Mail = reader.GetString("mail"),
					CreatedTime = reader.GetDateTime("createdTime", default),
					CommentsNum = reader.GetInt32("評論數", 0)
				};
				return new UsersEntity(dto);
			};

			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(UsersEntity entity)
		{
			string sql = @"UPDATE users SET
password = @password,
birthday = @birthday,
mail = @mail
WHERE id = @id";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@password", 50, entity.Password)
				.AddDateTime("@birthday", entity.Birthday)
				.AddNvarchar("@mail", 50, entity.Mail)
				.AddInt("@id", entity.Id)
				.Build();

			SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql, parameters);
		}
		public void UpdatePassword(UsersEntity entity)
		{
			string sql = @"UPDATE users SET
password = @password
WHERE id = @id";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@password", 50, entity.Password)
				.AddInt("@id", entity.Id)
				.Build();

			SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql, parameters);
		}
		public UsersDto GetByAccount(string account)
		{
			string sql = "SELECT * FROM users WHERE account = @account";

			SqlParameter parameter = new SqlParameter("@account", System.Data.SqlDbType.NVarChar, 50) { Value = account };

			Func<SqlDataReader, UsersDto> funcAssembler = reader =>
			{
				return new UsersDto
				{
					Id = reader.GetInt32("id", 0),
					Account = reader.GetString("account"),
					Password = reader.GetString("password"),
					Gender = reader.GetBoolean("gender"),
					Birthday = reader.GetDate("birthday").Date,
					Mail = reader.GetString("mail"),
					CreatedTime = reader.GetDateTime("createdTime", default)
				};
				//return new UsersEntity(dto);
			};
			return SqlDB.Get<UsersDto>(SqlDB.GetConnection, funcAssembler, sql, parameter);
		}

		public List<UsersWithComments> GetUserComments(int userId)
		{
			string sql = @"SELECT dramas.id, name, scores, contents, comments.createdTime
FROM users
JOIN comments ON fk_usersId = users.id
LEFT JOIN dramas ON dramas.id = fk_dramasId
WHERE fk_usersId = " + userId;

			Func<SqlDataReader, UsersWithComments> funcAssembler = reader =>
			{
				return new UsersWithComments
				{
					DramaId = reader.GetInt32("id", 0),
					DramaName = reader.GetString("name"),
					Scores = reader.GetByte("scores"),
					Contents = reader.GetString("contents"),
					CreatedTime = reader.GetDateTime("createdTime", default)
				};
			};
			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, null);
		}
	}
}
