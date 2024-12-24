using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            // query -> lấy data từ csdl -> database -> datagridview
            LoadTableMonHoc();
        }

        private void LoadTableMonHoc()
        {
            string query = "Select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtMaMH,txtTenMH,txtSoTiet,btnLuu});
            UnEnableControls(new List<Control> { btnSua,btnXoa });
            ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            txtMaMH.Focus();

        }
        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }
        private void UnEnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        private void ResetText(List<Control> controls)
        {
            foreach(Control control in controls)
            {
                control.Text = "";
            }
        }
        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;

            string query = $"insert into MonHoc values ('{maMH}',N'{tenMH}',{soTiet})";
            int kq = DataProvider.ThaoTacCSDL(query);
            if(kq > 0)
            {
                MessageBox.Show("Thêm môn học thành công!");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else
            {
                MessageBox.Show("Không thể thêm môn học, vui lòng xem lại");
            }
        }

        private void dtgvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMH.SelectedRows.Count > 0)
            {
                var donguocChon = dtgvMH.SelectedRows[0];


                // truyền giá trị lên các text box
                txtMaMH.Text = donguocChon.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = donguocChon.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = donguocChon.Cells["SoTiet"].Value.ToString();
                // hiển thị các textbox, button
                EnableControls(new List<Control> {txtTenMH, txtSoTiet,btnXoa, btnSua});
                // sáng ô  sửa và xóa
                txtMaMH.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;
            string query = $"Update MonHoc Set TenMH = N'{tenMH}',soTiet={soTiet} WHERE MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Sửa môn học thành công!");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu,btnXoa,btnSua });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else
            {
                MessageBox.Show("Không thể sửa môn học, vui lòng xem lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string query = $"DELETE MonHoc WHERE MaMH = '{maMH}'";
            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0)
            {
                MessageBox.Show("Xóa môn học thành công!");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu, btnXoa, btnSua });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else
            {
                MessageBox.Show("Không thể xóa môn học, vui lòng xem lại");
            }
        }

        private void comboMaMH_Click(object sender, EventArgs e)
        {
            LoadComboMaMH();
        }
        private void LoadComboMaMH()
        {
            string query = "SELECT MaMH,TenMH from MonHoc";
            comboMaMH.DataSource = DataProvider.LoadCSDL(query);
            comboMaMH.DisplayMember = "TenMH";
            comboMaMH.ValueMember = "MaMH";
        }

        private void btnTimMHtheoma_Click(object sender, EventArgs e)
        {
            string MaMH = (string)comboMaMH.SelectedValue;
            string query = $"SELECT * from MonHoc Where maMH = '{MaMH}'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnTimMHTheoND_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtNoidung.Text;
            string query = $"SELECT * from MonHoc Where tenMH LIKE N'%{tuKhoa}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }
    }
}
