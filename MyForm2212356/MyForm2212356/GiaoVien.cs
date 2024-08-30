using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm2212356
{
	public partial class GiaoVien : Form
	{
		public GiaoVien()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.cboMaSo = new System.Windows.Forms.ComboBox();
			this.rbNam = new System.Windows.Forms.CheckBox();
			this.rbNu = new System.Windows.Forms.CheckBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// cboMaSo
			// 
			this.cboMaSo.FormattingEnabled = true;
			this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
			this.cboMaSo.Location = new System.Drawing.Point(196, 64);
			this.cboMaSo.Name = "cboMaSo";
			this.cboMaSo.Size = new System.Drawing.Size(121, 24);
			this.cboMaSo.TabIndex = 0;
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Checked = true;
			this.rbNam.CheckState = System.Windows.Forms.CheckState.Checked;
			this.rbNam.Location = new System.Drawing.Point(391, 92);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(58, 20);
			this.rbNam.TabIndex = 1;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(391, 118);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(46, 20);
			this.rbNu.TabIndex = 1;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(373, 36);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(100, 22);
			this.txtHoTen.TabIndex = 2;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(280, 186);
			this.maskedTextBox1.Mask = "(\\0633).000.000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
			this.maskedTextBox1.TabIndex = 3;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(181, 131);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(522, 165);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(100, 22);
			this.txtMail.TabIndex = 5;
			// 
			// chklbNgoaiNgu
			// 
			this.chklbNgoaiNgu.FormattingEnabled = true;
			this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
			this.chklbNgoaiNgu.Location = new System.Drawing.Point(115, 234);
			this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
			this.chklbNgoaiNgu.Size = new System.Drawing.Size(120, 89);
			this.chklbNgoaiNgu.TabIndex = 6;
			// 
			// GiaoVien
			// 
			this.ClientSize = new System.Drawing.Size(688, 374);
			this.Controls.Add(this.chklbNgoaiNgu);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.maskedTextBox1);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.rbNu);
			this.Controls.Add(this.rbNam);
			this.Controls.Add(this.cboMaSo);
			this.Name = "GiaoVien";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private ComboBox cboMaSo;
		private CheckBox rbNam;
		private CheckBox rbNu;
		private TextBox txtHoTen;
		private MaskedTextBox maskedTextBox1;
		private DateTimePicker dateTimePicker1;
		private TextBox txtMail;
		private CheckedListBox chklbNgoaiNgu;
	}
}
