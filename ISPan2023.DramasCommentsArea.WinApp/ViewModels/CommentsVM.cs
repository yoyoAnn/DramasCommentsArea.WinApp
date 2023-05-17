using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.WinApp.ViewModels
{
	public class CommentsVM
	{
		public int Id { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		public DateTime CreatedTime { get; set; }
		public string DramaName { get; set; }
		public string UserAccount { get; set; }
	}
	public static class CommentsDtoExts
	{
		public static CommentsVM ToViewModel(this CommentsDto dto)
		{
			return new CommentsVM
			{
				Id = dto.Id,
				Scores = dto.Scores,
				Contents = dto.Contents,
				CreatedTime = dto.CreatedTime,
				DramaName = dto.DramaName,
				UserAccount = dto.UserAccount
			};
		}
	}
}
