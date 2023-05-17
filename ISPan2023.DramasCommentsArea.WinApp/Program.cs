using ISPan2023.DramasCommentsArea.WinApp.From_User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	internal static class Program
	{
		/// <summary>
		/// 應用程式的主要進入點。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormLogin());
			//Application.Run(new FormUserMain(2));
		}
	}
}
