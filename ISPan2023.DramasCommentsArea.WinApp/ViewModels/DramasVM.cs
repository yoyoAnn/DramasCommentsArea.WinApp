using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISPan2023.DramasCommentsArea.WinApp.ViewModels
{
	public class DramasVM
	{
		public int Id { get; set; }
		[Display(Name = "名稱")]
		public string Name { get; set; }
		[Display(Name = "集數")]
		public int Episode { get; set; }
		[Display(Name = "發行日")]
		public DateTime PublishDate { get; set; }
		[Display(Name = "OTT平台")]
		public string Ott { get; set; }
		[Display(Name = "大綱")]
		public string Description { get; set; }
		[Display(Name = "編劇")]
		public string Writer { get; set; }
		[Display(Name = "導演")]
		public string Director { get; set; }
		[Display(Name = "演員")]
		public string Actors { get; set; }
		[Display(Name = "封面")]
		public string Path { get; set; }
	}
	public static class DramasDtoExts
	{
		public static DramasVM ToViewModel(this DramasDto dto)
		{
			return new DramasVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Episode = dto.Episode,
				PublishDate =dto.PublishDate,
				Ott = dto.Ott,
				Description = dto.Description,
				Writer = dto.Writer,
				Director = dto.Director,
				Actors = dto.Actors,
				Path = dto.Path
			};
		}
	}
}
