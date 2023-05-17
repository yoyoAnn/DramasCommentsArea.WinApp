using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas
{
	public class DramasAddDto
	{
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
	public static class DramasAddDtoExts
	{
		public static DramasEntity ToEntity(this DramasAddDto dto)
		{
			return new DramasEntity(dto);
		}
	}

}
