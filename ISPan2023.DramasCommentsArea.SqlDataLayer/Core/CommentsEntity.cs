using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Core
{
	public class CommentsEntity
	{
		public int Id { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		public DateTime CreatedTime { get; set; }
		public int DramaId { get; set; }
		public string DramaName { get; set; }
		public int UserId { get; set; }
		public string UserAccount { get; set; }
		public CommentsEntity(CommentsDto dto)
		{
			this.Id = dto.Id;
			this.Scores = dto.Scores;
			this.Contents = dto.Contents;
			this.CreatedTime = dto.CreatedTime;
			this.DramaName = dto.DramaName;
			this.UserAccount = dto.UserAccount;
		}
		public CommentsEntity(CommentsAddDto dto)
		{
			this.Scores = dto.Scores;
			this.Contents = dto.Contents;
			this.CreatedTime = dto.CreatedTime;
			this.DramaId = dto.DramaId;
			this.UserId = dto.UserId;
		}
		public CommentsEntity(CommentsEditDto dto)
		{
			this.Id = dto.Id;
			this.Scores = dto.Scores;
			this.Contents = dto.Contents;
			this.CreatedTime = dto.CreatedTime;
		}
	}
}
