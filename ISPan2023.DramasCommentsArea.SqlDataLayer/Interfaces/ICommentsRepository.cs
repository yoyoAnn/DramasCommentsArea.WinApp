using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces
{
	public interface ICommentsRepository
	{
		void Create(CommentsEntity entity);
		void Update(CommentsEntity entity);
		void Delete(int commentsId);
		CommentsEntity Get(int commentsId);
		List<CommentsEntity> Search(string commentsId, string sortName, byte scores);
		List<CommentsEntity> SearchUser(int dramaId, int userId);
	}
}
