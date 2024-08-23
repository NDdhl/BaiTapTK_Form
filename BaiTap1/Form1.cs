using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
	public partial class rbD : Form
	{
		public rbD()
		{
			InitializeComponent();
		}

		private void rbNam_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show($"Bạn chọn giới tính Nam","Thông báo");
		}

		private void rbNu_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show($"Bạn chọn giới tính Nữ", "Thông báo");
		}

		private void btnToMau_Click(object sender, EventArgs e)
		{
			if(rbDo.Checked)
				txtHopMau.BackColor = Color.Red;
			else
				txtHopMau.BackColor= Color.Green;
		}
	}
}
