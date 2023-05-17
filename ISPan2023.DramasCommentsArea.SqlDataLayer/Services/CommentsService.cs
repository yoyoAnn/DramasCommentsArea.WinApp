using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Services
{
	public class CommentsService
	{
		private readonly ICommentsRepository _repo;
		public CommentsService(ICommentsRepository repo)
		{
			_repo = repo;
		}
		public void Create(CommentsAddDto dto)
		{
			//檢查user是否已評論過
			var data = _repo.SearchUser(dto.DramaId, dto.UserId);
			if (data != null && data.Count > 0) throw new Exception("您已評論過該戲劇。");

			//若user沒評論過，允許新曾評論
			CommentsEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		public void Update(CommentsEditDto dto)
		{
			////檢查name是否已存在
			//List<DramasEntity> data = _repo.Search(dto.Name, null);
			//if (data != null && data.Count > 0)
			//{
			//	if (data[0].Id != dto.Id) throw new Exception("名稱已存在，不允許更新");
			//}

			////若名稱是唯一的，允許更新紀錄
			//DramasEntity entity = dto.ToEntity();
			//_repo.Update(entity);
		}
		public void Delete(int commentsId)
		{
			_repo.Delete(commentsId);
		}
		public CommentsEditDto Get(int commentsId)
		{
			return _repo.Get(commentsId).ToEditDto();
		}
		public List<CommentsDto> Search(string dramasName, string sortName, byte scores)
		{
			return _repo.Search(dramasName, sortName, scores).Select(x => x.ToDto()).ToList();
		}
		public List<CommentsAddDto> SearchUser(int dramaId, int userId)
		{
			return _repo.SearchUser(dramaId, userId).Select(x => x.ToAddDto()).ToList();
		}
	}
}
