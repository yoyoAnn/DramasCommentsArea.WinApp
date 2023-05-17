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
	public class SqlDramasRepository : IDramasRepository
	{
		public void Create(DramasEntity entity)
		{
			string sql = @"SET NOCOUNT ON;
INSERT INTO dramas Values
(@name, @episode, @publishDate, @ott, @description, @writer, @director, @actors, @path)";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@name", 50, entity.Name)
				.AddTinyInt("@episode", (byte)entity.Episode)
				.AddDate("@publishDate", entity.PublishDate.Date)
				.AddNvarchar("@ott", 50, entity.Ott)
				.AddNvarchar("@description", 200, entity.Description)
				.AddNvarchar("@writer", 50, entity.Writer)
				.AddNvarchar("@director", 50, entity.Director)
				.AddNvarchar("@actors", 50, entity.Actors)
				.AddNvarchar("@path", 100, entity.Path)
				.Build();

			SqlDB.Create(SqlDB.GetConnection, sql, parameters);
		}

		public void Delete(int dramasId)
		{
			string sql = "DELETE FROM dramas WHERE id = " + dramasId;

			SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql);
		}

		public DramasEntity Get(int dramasId)
		{
			string sql = "SELECT * FROM dramas WHERE id = " + dramasId;

			Func<SqlDataReader, DramasEntity> funcAssembler = reader =>
			{
				DramasDto dto = new DramasDto
				{
					Id = reader.GetInt32("id", 0),
					Name = reader.GetString("name"),
					Episode = reader.GetByte("episode"),
					PublishDate = reader.GetDateTime("publishDate", default),
					Ott = reader.GetString("ott"),
					Description = reader.GetString("description"),
					Writer = reader.GetString("writer"),
					Director = reader.GetString("director"),
					Actors = reader.GetString("actors"),
					Path = reader.GetString("path")
				};
				return new DramasEntity(dto);
			};
			return SqlDB.Get(SqlDB.GetConnection, funcAssembler, sql, null);
		}

		public List<DramasWithComments> GetComments(int dramasId)
		{
			string sql = @"SELECT scores, contents, account, comments.createdTime
FROM comments
LEFT JOIN dramas ON dramas.id = fk_dramasId
LEFT JOIN users ON fk_usersId = users.id
WHERE dramas.id = " + dramasId;

			Func<SqlDataReader, DramasWithComments> funcAssembler = reader =>
			{
				return new DramasWithComments
				{
					Scores = reader.GetByte("scores"),
					Contents = reader.GetString("contents"),
					CreatedTime = reader.GetDateTime("createdTime", default),
					UserAccount = reader.GetString("account")
				};
			};
			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, null);
		}

		public List<DramasEntity> Search(string dramasName, string sortName)
		{
			List<SqlParameter> parameters = new List<SqlParameter>();
			string sql = "SELECT * FROM dramas";

			#region 組合出 where 條件
			string where = string.Empty;
			if (string.IsNullOrEmpty(dramasName) == false)
			{
				where += $" WHERE name LIKE '%{dramasName}%'";
				//where += " WHERE name = @name";
				//parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.NVarChar, 50) { Value = dramasName });
			}
			sql += where;
			#endregion

			#region 組合出 order by 條件
			if(string.IsNullOrEmpty(sortName) == false)
			{
				sql += $" ORDER BY {sortName}";
			}
			else
			{
				sql += " ORDER BY id";
			}
			#endregion
			Func<SqlDataReader, DramasEntity> funcAssembler = reader =>
			{
				DramasDto dto = new DramasDto
				{
					Id = reader.GetInt32("id", 0),
					Name = reader.GetString("name"),
					Episode = reader.GetByte("episode"),
					PublishDate = reader.GetDateTime("publishDate", default),
					Ott = reader.GetString("ott"),
					Description = reader.GetString("description"),
					Writer = reader.GetString("writer"),
					Director = reader.GetString("director"),
					Actors = reader.GetString("actors"),
					Path = reader.GetString("path")
				};

				return new DramasEntity(dto);
			};

			return SqlDB.Search(SqlDB.GetConnection, funcAssembler, sql, parameters.ToArray());
		}

		public void Update(DramasEntity entity)
		{
			string sql = @"UPDATE dramas SET
name = @name,
episode = @episode,
publishDate = @publishDate,
ott = @ott,
description = @description,
writer = @writer,
director = @director,
actors = @actors,
path = @path
WHERE Id = @Id";

			var parameters = SqlParameterBuilder.Create()
				.AddNvarchar("@name", 50, entity.Name)
				.AddTinyInt("@episode", (byte)entity.Episode)
				.AddDate("@publishDate", entity.PublishDate)
				.AddNvarchar("@ott", 50, entity.Ott)
				.AddNvarchar("@description", 200, entity.Description)
				.AddNvarchar("@writer", 50, entity.Writer)
				.AddNvarchar("@director", 50, entity.Director)
				.AddNvarchar("@actors", 50, entity.Actors)
				.AddNvarchar("@path", 100, entity.Path)
				.AddInt("@id", entity.Id)
				.Build();

			SqlDB.UpdateOrDelete(SqlDB.GetConnection, sql, parameters);
		}
	}
}
