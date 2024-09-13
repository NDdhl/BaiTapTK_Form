using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox7.Text = openFileDialog.FileName;
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            pictureBox2.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maSinhVien = columnHeader1.Text;
            // Kiểm tra sự tồn tại của sinh viên trong danh sách
            SinhVien sinhVien = dssv.FirstOrDefault(sv => sv.MaSinhVien == maSinhVien);

            if (sinhVien != null)
            {
                // Cập nhật thông tin sinh viên
                sinhVien.TenSinhVien = columnHeader2.Text;
                sinhVien.HinhAnh = textBox7.Text;
            }
            else
            {
                // Thêm sinh viên mới vào danh sách
                sinhVien = new SinhVien
                {
                    MaSinhVien = maSinhVien,
                    TenSinhVien = columnHeader2.Text,
                    HinhAnh = textBox7.Text
                };
                dssv.Add(sinhVien);
            }

            // Cập nhật ListView
            LoadListView();
        }

        private void LoadListView()
        {
            listView1.Items.Clear();
            foreach (var sv in dssv)
            {
                ListViewItem item = new ListViewItem(sv.MaSinhVien);
                item.SubItems.Add(sv.TenSinhVien);
                listView1.Items.Add(item);
            }
        }
    }
}
