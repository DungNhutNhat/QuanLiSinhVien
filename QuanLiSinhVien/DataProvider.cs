using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien
{
    public class DataProvider
    {
        const string connString = "Data Source=DESKTOP-C60BEB9\\SQLEXPRESS;Initial Catalog=QlSinhVien;Integrated Security=True;TrustServerCertificate=True";
        private static SqlConnection connection;
        public static List<DangNhap> DangNhaps = new List<DangNhap>();
        public static void OpenConnection()
        {
            connection = new SqlConnection(connString); // khởi tạo db
            connection.Open();

        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static void GetAllDangNhap()
        {
            try
            {
                OpenConnection();
                string query = "Select * from DanhNhap";
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.TaiKhoan = reader["TenDangNhap"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    dangNhap.HoTen = reader["HoTen"].ToString();
                    dangNhap.Quyen = reader["Quyen"].ToString();
                    DangNhaps.Add(dangNhap);
                }
            }catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public static DataTable LoadCSDL(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query,connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
    }
}
