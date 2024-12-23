using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatkhau.Text;
            bool isFound = false;
            foreach (var dn in DataProvider.DangNhaps)
            {
                if(dn.TaiKhoan == tenDangNhap && dn.MatKhau == matKhau)
                {
                   isFound = true;
                    break;
                }            
            }
            if (isFound)
            {
                MainFrm f = new MainFrm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("sai tên tk hoặc mk");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataProvider.GetAllDangNhap();
        }
    }
}
