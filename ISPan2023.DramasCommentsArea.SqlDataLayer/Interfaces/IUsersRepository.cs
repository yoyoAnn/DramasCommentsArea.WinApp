using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces
{
	public interface IUsersRepository
	{
		void Create(UsersEntity entity);
		void Update(UsersEntity entity);
		void UpdatePassword(UsersEntity entity);
		void Delete(int usersId);
		UsersEntity Get(int usersId);
		List<UsersEntity> Search(int commentsNum, string usersAccount = null, string sortName = null);
		UsersDto GetByAccount(string account);
		List<UsersWithComments> GetUserComments(int userId);
	}
	public class UsersWithComments
	{
		public int DramaId { get; set; }
		public string DramaName { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		public DateTime CreatedTime { get; set; }
	}
}
