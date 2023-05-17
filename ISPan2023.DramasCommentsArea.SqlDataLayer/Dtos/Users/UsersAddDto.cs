using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users
{
	public class UsersAddDto
	{
		public string Account { get; set; }
		public string Password { get; set; }
		public bool Gender { get; set; }
		public DateTime Birthday { get; set; }
		public string Mail { get; set; }
		public DateTime CreatedTime { get; set; }
	}
	public static class UsersAddDtoExts
	{
		public static UsersEntity ToEntity(UsersAddDto dto)
		{
			return new UsersEntity(dto);
		}
	}
}
