using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISPan2023.DramasCommentsArea.WinApp
{
	public partial class urGender : UserControl, ISmartControl
	{
		public urGender()
		{
			InitializeComponent();
		}

		public string GetValue()
		{
			if (radioButton1.Checked)
			{
				return "1";
			}
			else if (radioButton2.Checked)
			{
				return "2";
			}
			return "";
		}
	}
}
