using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Core
{
	public class UsersEntity
	{
		public int Id { get; private set; }
		public string Account { get; private set; }
		public string Password { get; private set; }
		public bool Gender { get; private set; }
		public DateTime Birthday { get; private set; }
		public string Mail { get; private set; }
		public DateTime CreatedTime { get; private set; }
		public int CommentsNum { get; private set; }
		public UsersEntity(UsersDto dto)
		{
			this.Id = dto.Id;
			this.Account = dto.Account;
			this.Password = dto.Password;
			this.Gender = dto.Gender;
			this.Birthday = dto.Birthday;
			this.Mail = dto.Mail;
			this.CreatedTime = dto.CreatedTime;
			this.CommentsNum = dto.CommentsNum;
		}
		public UsersEntity(UsersAddDto dto)
		{
			this.Id = 0;
			this.Account = dto.Account;
			this.Password = dto.Password;
			this.Gender = dto.Gender;
			this.Birthday = dto.Birthday;
			this.Mail = dto.Mail;
			this.CreatedTime = dto.CreatedTime;
		}
		public UsersEntity(UsersEditDto dto)
		{
			this.Id = dto.Id;
			this.Account = dto.Account;
			this.Password = dto.Password;
			this.Gender = dto.Gender;
			this.Birthday = dto.Birthday;
			this.Mail = dto.Mail;
			this.CreatedTime = dto.CreatedTime;
		}
	}
}
