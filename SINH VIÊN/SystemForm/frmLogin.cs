using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SINH_VIÊN.SO;
using SINH_VIÊN.DAL;

namespace SINH_VIÊN.SystemForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();  
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        #region login method
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Thực hiện đăng nhập vào ứng Demo với thông tin trên
            string loginApp = LoginProvider.LoginApp(
                MyApp.gHostDB, MyApp.gPortDB, MyApp.gServiceNameDB, txtUserName.Text, txtPassword.Text,
                txtUserName.Text, txtPassword.Text);
            if (loginApp.Equals("true"))
            {
                MyApp.gConnected = true;
                MyApp.gUserDB = txtUserName.Text;
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
        
        #endregion


        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectionStart = 0;
            txtPassword.SelectionLength = txtPassword.Text.Length;
        }

        
    }
}
