using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Dtos.Dramas;
using ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Services
{
	public class DramasService
	{
		private readonly IDramasRepository _repo;
		public DramasService(IDramasRepository repo)
		{
			_repo = repo;
		}
		public void Create(DramasAddDto dto)
		{
			//檢查name是否已存在
			var data = _repo.Search(dto.Name, null);
			if (data != null && data.Count > 0) throw new Exception("名稱已存在，請重新輸入");

			//若名稱是唯一的，允許新建紀錄
			DramasEntity entity = dto.ToEntity();
			_repo.Create(entity);
		}
		public void Update(DramasEditDto dto)
		{
			//檢查name是否已存在
			List<DramasEntity> data = _repo.Search(dto.Name, null);
			if (data != null && data.Count > 0)
			{
				if (data[0].Id != dto.Id) throw new Exception("名稱已存在，不允許更新");
			}

			//若名稱是唯一的，允許更新紀錄
			DramasEntity entity = dto.ToEntity();
			_repo.Update(entity);
		}
		public void Delete(int dramasId)
		{
			_repo.Delete(dramasId);
		}
		public DramasEditDto Get(int dramasId)
		{
			return _repo.Get(dramasId).ToEditDto();
		}
		public List<DramasDto> Search(string dramasName, string sortName)
		{
			return _repo.Search(dramasName, sortName).Select(x => x.ToDto()).ToList();
		}
	}
}
