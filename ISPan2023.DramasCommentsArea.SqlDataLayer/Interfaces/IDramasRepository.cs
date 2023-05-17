using ISPan2023.DramasCommentsArea.SqlDataLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPan2023.DramasCommentsArea.SqlDataLayer.Interfaces
{
	public interface IDramasRepository
	{
		void Create(DramasEntity entity);
		void Update(DramasEntity entity);
		void Delete(int dramasId);
		DramasEntity Get(int dramasId);
		List<DramasEntity> Search(string dramasName, string sortName);
		List<DramasWithComments> GetComments(int dramasId);
	}
	public class DramasWithComments
	{
		//public int DramaId { get; set; }
		//public string DramaName { get; set; }
		public byte Scores { get; set; }
		public string Contents { get; set; }
		public DateTime CreatedTime { get; set; }
		public string UserAccount { get; set; }
	}
}
