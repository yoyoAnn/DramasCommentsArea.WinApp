using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments
{
	public class CommentsDto
	{
		public int Id { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		private DateTime _createdTime { get; set; }
		public DateTime CreatedTime
		{
			get { return _createdTime; }
			set { _createdTime = Convert.ToDateTime(value.ToString("yyyy/MM/dd HH:mm")); }
		}
		public string DramaName { get; set; }
		public string UserAccount { get; set; }

	}
	public static class CommentsEntityExts
	{
		public static CommentsDto ToDto(this CommentsEntity entity)
		{
			return new CommentsDto
			{
				Id = entity.Id,
				Scores = entity.Scores,
				Contents = entity.Contents,
				CreatedTime = entity.CreatedTime,
				DramaName = entity.DramaName,
				UserAccount = entity.UserAccount
			};
		}
	}
}
