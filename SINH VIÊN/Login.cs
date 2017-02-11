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
using SINH_VIÊN.SO;
using SINH_VIÊN.DAL;

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
            //Thực hiện đăng nhập vào ứng Demo với thông tin trên
            string loginApp = Login.LoginApp(
                MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUser.Text, txtPass.Text,
                txtUser.Text, txtPass.Text);
            if (loginApp.Equals("true"))
            {
                MyApp.gConnected = true;
                MyApp.gUserDB = txtUser.Text;
                //FrmLogin.Current.ItemMnuSystemLoginChange = "Đăng xuất";
                //Goi phan quyen o day
                SINH_VIÊN.SO.PhanQuyen.ShowAll();
                //close form
                this.Close();
            }
            else
            {
                //e.Result = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gAppCoded, loginApp);
                string mMessage;
                mMessage = string.Format("Đăng nhập vào {0} không thành công. Bạn hãy kiểm tra lại các thông tin đăng nhập.\r\n{1}", MyApp.gHostDB, loginApp);
                MessageBox.Show(mMessage);
            }
        }
        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.SelectionStart = 0;
            txtPass.SelectionLength = txtPass.Text.Length;
        }
    }
}
