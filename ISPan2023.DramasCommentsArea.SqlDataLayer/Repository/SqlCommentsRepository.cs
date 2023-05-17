using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
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
	public class SqlCommentsRepository : ICommentsRepository
	{
		public void Create(CommentsEntity entity)
		{
			string sql = @"SET NOCOUNT ON;
INSERT INTO comments VALUES
(@scores, @contents, @fk_dramasId, @fk_usersId, DEFAULT)";

			var parameters = SqlParameterBuilder.Create()
				.AddTinyInt("@scores", entity.Scores)
				.AddNvarchar("@contents", 100, entity.Contents)
				.AddInt("fk_dramasId",entity.DramaId)
				.AddInt("fk_usersId", entity.UserId)
				.Build();

			SqlDB.Create(SqlDB.GetConnection, sql, parameters);
		}
		public List<CommentsEntity> SearchUser(int dramaId, int userId)
		{
			List<SqlParameter> parameters = new List<SqlParameter>()
			{
				new SqlParameter("@dramaId",System.Data.SqlDbType.Int) {Value = dramaId},
				new SqlParameter("@userId",System.Data.SqlDbType.Int) {Value = userId},
			};

			string sql = @"SELECT comments.id, dramas.id, comments.scores, comments.contents, comments.createdTime, users.id
FROM comments
LEFT JOIN dramas ON fk_dramasId = dramas.id
LEFT JOIN users ON fk_usersId = users.id
WHERE fk_dramasId = @dramaId AND fk_usersId = @userId";
			
			Func<SqlDataReader, CommentsEntity> funcAssembler = reader =>
			{
				CommentsAddDto dto = new CommentsAddDto
				{
					Scores = reader.GetByte("scores"),
					Contents = reader.GetString("contents"),
					CreatedTime = reader.GetDateTime("createdTime", default)
					//DramaId = reader.GetInt32("fk_dramasId", 0),
					//UserId = reader.GetInt32("fk_usersId", 0)
				};
				return new CommentsEntity(dto);
			};

			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, parameters.ToArray());
		}
		public void Delete(int commentsId)
		{
			throw new NotImplementedException();
		}
		public CommentsEntity Get(int commentsId)
		{
			throw new NotImplementedException();
		}
		public List<CommentsEntity> Search(string dramaName, string sortName, byte scores)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = @"SELECT comments.id, dramas.name, comments.scores, comments.contents, comments.createdTime, users.account
FROM comments
LEFT JOIN dramas ON fk_dramasId = dramas.id
LEFT JOIN users ON fk_usersId = users.id";

			#region 組合出 where 條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(dramaName) == false)
			{
				where += $" AND dramas.name LIKE '%{dramaName}%'";
			}
			if (scores != 0)
			{
				where += $" AND comments.scores = {scores}";
			}
			sql += string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where.Substring(5);
			#endregion

			#region 組合出 order by 條件
			if (string.IsNullOrEmpty(sortName) == false)
			{
				sql += $" ORDER BY {sortName}";
			}
			else
			{
				sql += " ORDER BY id";
			}
			#endregion

			Func<SqlDataReader, CommentsEntity> funcAssembler = reader =>
			{
				CommentsDto dto = new CommentsDto
				{
					Id = reader.GetInt32("id", 0),
					Scores = reader.GetByte("scores"),
					Contents = reader.GetString("contents"),
					CreatedTime = reader.GetDateTime("createdTime", default),
					DramaName = reader.GetString("name"),
					UserAccount = reader.GetString("account")
				};
				return new CommentsEntity(dto);
			};

			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, parameters.ToArray());
		}
		public void Update(CommentsEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
