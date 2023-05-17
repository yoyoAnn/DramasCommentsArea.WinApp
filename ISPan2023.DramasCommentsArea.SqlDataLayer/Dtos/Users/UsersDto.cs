using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users
{
	public class UsersDto
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public bool Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string Mail { get; set; }
		public DateTime CreatedTime { get; set; }
		public int CommentsNum { get; set; }
	}
	public static class UsersEntityExts
	{
		public static UsersDto ToDto(this UsersEntity entity)
		{
			return new UsersDto
			{
				Id = entity.Id,
				Account = entity.Account,
				Password = entity.Password,
				Gender = entity.Gender,
				Birthday = entity.Birthday,
				Mail = entity.Mail,
				CreatedTime = entity.CreatedTime,
				CommentsNum = entity.CommentsNum
			};
		}
	}
}

