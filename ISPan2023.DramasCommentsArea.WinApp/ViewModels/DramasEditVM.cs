using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ISPan2023.DramasCommentsArea.WinApp.ViewModels
{
	public class DramasEditVM
	{
		[Display(Name = "編號")]
		public int Id { get; set; }

		[Display(Name = "名稱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(50, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Name { get; set; }

		[Display(Name = "集數")]
		[Required(ErrorMessage = "{0}必填")]
		[Range(1, 255, ErrorMessage = "{0}必填，且範圍要在{1}~{2}之間")]
		public int Episode { get; set; }

		[Display(Name = "發行日")]
		[Required(ErrorMessage = "{0}必填")]
		public DateTime PublishDate { get; set; }

		[Display(Name = "OTT平台")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(50, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Ott { get; set; }

		[Display(Name = "大綱")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(200, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Description { get; set; }

		[Display(Name = "編劇")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(50, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Writer { get; set; }

		[Display(Name = "導演")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(50, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Director { get; set; }

		[Display(Name = "演員")]
		[Required(ErrorMessage = "{0}必填")]
		[MaxLength(50, ErrorMessage = "{0}長度不可大於{1}字")]
		public string Actors { get; set; }

		[Display(Name = "封面")]
		[Required(ErrorMessage = "{0}沒有檔案")]
		public string Path { get; set; }
	}
	public static class DramasEditDtoExts
	{
		public static DramasEditVM ToViewModel(this DramasEditDto dto)
		{
			return new DramasEditVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Episode = dto.Episode,
				PublishDate = dto.PublishDate,
				Ott = dto.Ott,
				Description = dto.Description,
				Writer = dto.Writer,
				Director = dto.Director,
				Actors = dto.Actors,
				Path = dto.Path
			};
		}
	}
	public static class DramasEditVMExts
	{
		public static DramasEditDto ToEditDto(this DramasEditVM vm)
		{
			return new DramasEditDto
			{
				Id = vm.Id,
				Name = vm.Name,
				Episode = vm.Episode,
				PublishDate = vm.PublishDate,
				Ott = vm.Ott,
				Description = vm.Description,
				Writer = vm.Writer,
				Director = vm.Director,
				Actors = vm.Actors,
				Path = vm.Path
			};
		}
	}
}
