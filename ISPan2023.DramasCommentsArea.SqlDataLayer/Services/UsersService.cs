using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Services
{
	public class UsersService
	{
		private readonly IUsersRepository _repo;
		public UsersService(IUsersRepository repo)
		{
			_repo = repo;
		}
		public void Create(UsersAddDto dto)
		{
			////檢查name是否已存在
			//var data = _repo.Search(dto.Name, null);
			//if (data != null && data.Count > 0) throw new Exception("名稱已存在，請重新輸入");

			////若名稱是唯一的，允許新建紀錄
			//DramasEntity entity = dto.ToEntity();
			//_repo.Create(entity);
		}
		public void Update(UsersEditDto dto)
		{
			UsersEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}
		public void UpdatePassword(UsersEditDto dto)
		{
			UsersEntity entity = dto.ToEntity();
			_repo.UpdatePassword(entity);
		}
		public void Delete(int usersId)
		{
			_repo.Delete(usersId);
		}
		public UsersEditDto Get(int usersId)
		{
			return _repo.Get(usersId).ToEditDto();
		}
		public List<UsersDto> Search(int commentsNum, string usersAccount = null, string sortName = null)
		{
			return _repo.Search(commentsNum, usersAccount, sortName).Select(x => x.ToDto()).ToList();
		}
		public int IsValid(string account, string password)
		{
			//precondition checks
			//account, password必填
			//if (string.IsNullOrEmpty(account)) { throw new ArgumentException(nameof(account)); }
			//if (string.IsNullOrEmpty(password)) { throw new ArgumentException(nameof(password)); }

			//取得單一使用者
			UsersDto user = _repo.GetByAccount(account);
			if (user == null) { return 0; }

			//判斷密碼是否正確
			string passwordInDb = user.Password;

			//如果不拘大小寫
			//return (passwordInDb.ToLower() == password.ToLower());

			//如果要區分大小寫
			if(passwordInDb == password)
			{
				return user.Id;
			}
			return 0;
		}
	}
}
