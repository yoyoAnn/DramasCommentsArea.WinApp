using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas
{
	public class DramasEditDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Episode { get; set; }
		public DateTime PublishDate { get; set; }
		public string Ott { get; set; }
		public string Description { get; set; }
		public string Writer { get; set; }
		public string Director { get; set; }
		public string Actors { get; set; }
		public string Path { get; set; }
	}
	public static class DramasEditExts
	{
		public static DramasEditDto ToEditDto(this DramasEntity entity)
		{
			return new DramasEditDto
			{
				Id = entity.Id,
				Name = entity.Name,
				Episode = entity.Episode,
				PublishDate = entity.PublishDate,
				Ott = entity.Ott,
				Description = entity.Description,
				Writer = entity.Writer,
				Director = entity.Director,
				Actors = entity.Actors,
				Path = entity.Path
			};
		}
		public static DramasEntity ToEntity(this DramasEditDto dto)
		{
			return new DramasEntity(dto);
		}
	}
}
