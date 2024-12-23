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
            string query = "Select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }
    }
}
