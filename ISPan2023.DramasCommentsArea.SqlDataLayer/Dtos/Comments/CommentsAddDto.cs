using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Comments
{
	public class CommentsAddDto
	{
		public byte Scores { get; set; }
		public string Contents { get; set; }
		private DateTime _createdTime { get; set; }
		public DateTime CreatedTime
		{
			get { return _createdTime; }
			set { _createdTime = Convert.ToDateTime(value.ToString("yyyy/MM/dd HH:mm")); }
		}
		public int DramaId { get; set; }
		public int UserId { get; set; }

	}
	public static class CommentsAddDtoExts
	{
		public static CommentsEntity ToEntity(this CommentsAddDto dto)
		{
			return new CommentsEntity(dto);
		}
		public static CommentsAddDto ToAddDto(this CommentsEntity entity)
		{
			return new CommentsAddDto
			{
				Scores = entity.Scores,
				Contents = entity.Contents,
				CreatedTime = entity.CreatedTime
			};
		}
	}
}
