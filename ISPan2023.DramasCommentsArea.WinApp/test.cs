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
	public partial class test : Form
	{
		public test()
		{
			InitializeComponent();
			label1.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//string v1 = this.waTextBox1.GetValue();
			//string v2 = this.waTextBox2.GetValue();
			//string v3 = this.waCheckBox1.GetValue();

			//label1.Text = v1 + v2 + v3;
			label1.Text = string.Empty;
			foreach (var ctrl in this.Controls.OfType<ISmartControl>())
			{
				string v = ctrl.GetValue();
				label1.Text += v;
			}
		}
	}
}
