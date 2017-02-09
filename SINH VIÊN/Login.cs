using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SINH_VIÊN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cnt = new SqlConnection(@"Data Source=DESKTOP-QD51D97\SQLEXPRESS;Initial Catalog=THI_TRAC_NGHIEM;Integrated Security=True");
        private void KetNoiCSDL()
        {
            try
            {
                cnt.Open();
                string sql = "select * from DANHSACHNGUOIDUNG";
                SqlCommand cm = new SqlCommand(sql, cnt);
                cm.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối! Hãy kiểm tra lại!");
            }

            cnt.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Thoat frm = new Thoat();
            frm.Show();
            this.Hide();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
           
        }

    }
}
