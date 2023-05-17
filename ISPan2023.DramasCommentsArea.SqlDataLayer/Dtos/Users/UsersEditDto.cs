using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users
{
	public class UsersEditDto
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public bool Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string Mail { get; set; }
		public DateTime CreatedTime { get; set; }
	}
	public static class UsersEditExts
	{
		public static UsersEditDto ToEditDto(this UsersEntity entity)
		{
			return new UsersEditDto
			{
				Account = entity.Account,
				Password = entity.Password,
				Gender = entity.Gender,
				Birthday = entity.Birthday,
				Mail = entity.Mail,
				CreatedTime = entity.CreatedTime
			};
		}
		public static UsersEntity ToEntity(this UsersEditDto dto)
		{
			return new UsersEntity(dto);
		}
	}
}
