using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SINH_VIÊN.SO;
using System.Data.Common;
using System.Data;

namespace SINH_VIÊN.DAL
{
    public class Login
    {
        #region Login vào ứng dụng
        public static string LoginApp(
            string host, string port, string servicename, string userdb, string pwddb,
            string username, string password)
        {
            string result = "Lỗi đăng nhập.";
            DataAccess dbA = new DataAccess();            
            MyApp.MSSQLConnectionString = MyApp.GetLoginMSSQL(host, servicename, userdb, pwddb);
            dbA.ConnectionString = MyApp.MSSQLConnectionString;
            string sql = "SELECT code From [Users] WHERE code='" + username + "'";
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            try
            {
                DbDataReader reader = dbA.ExecuteAsDataReaderSql(sql,ParaMeterCollection);
                if (reader.Read())
                    result = "true";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }
        #endregion

    }
}
