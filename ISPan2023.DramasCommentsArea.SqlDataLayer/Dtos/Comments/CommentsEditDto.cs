using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments
{
	public class CommentsEditDto
	{
		public int Id { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		public DateTime CreatedTime { get; set; }
	}
	public static class CommentsEditExts
	{
		public static CommentsEditDto ToEditDto(this CommentsEntity entity)
		{
			return new CommentsEditDto
			{
				Scores = entity.Scores,
				Contents = entity.Contents,
				CreatedTime = entity.CreatedTime
			};
		}
		public static CommentsEntity ToEntity(this CommentsEditDto dto)
		{
			return new CommentsEntity(dto);
		}
	}
}
