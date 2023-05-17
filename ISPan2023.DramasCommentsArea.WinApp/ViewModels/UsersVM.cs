using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.WinApp.ViewModels
{
	public class UsersVM
	{
		public int Id { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string Mail { get; set; }
		public DateTime CreatedTime { get; set; }
		public int CommentsNum { get; set; }
	}
	public static class UsersDtoExts
	{
		public static UsersVM ToViewModel(this UsersDto dto)
		{
			string gender = "";
			if (dto.Gender == true) { gender = "女"; }
			else { gender = "男"; }

			return new UsersVM
			{
				Id = dto.Id,
				Account = dto.Account,
				Password = dto.Password,
				Gender = gender,
				Birthday = dto.Birthday,
				Mail = dto.Mail,
				CreatedTime = dto.CreatedTime,
				CommentsNum = dto.CommentsNum
			};
		}
	}
}
