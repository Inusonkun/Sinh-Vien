using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using SINH_VIÊN.DAL;

namespace SINH_VIÊN.SO
{
    /// <summary>    
    ///Đối tượng MyApp nằm trong vùng SO (System objects) này chứa các thông tin cơ bản về ứng dụng như:
    ///....
    /// </summary>
    public class MyApp
    {
        /// <summary>
        /// Quy định lại về đặt mã ứng dụng. Dạng ABC.DEV
        /// - ABC: mã chính thức
        /// - DEV: nếu đặt là DEV có nghĩa là bản đang phát triển, dành cho IT.
        /// </summary>
        public static FrmLogin frmmain = null;

        #region Thiết lập các thông số chung cho lớp DataAccess
        /// <summary>
        /// Sử dụng cho ProviderName trong lớp DataAccess, áp dụng cho Oracle
        /// </summary>
        public static string OracleProviderName = "Oracle.DataAccess.Client";

        /// <summary>
        /// Provider cho lớp DataAccess, ap dụng cho MSSQL
        /// </summary>
        public static string MSSQLProviderName = "System.Data.SqlClient";

        /// <summary>
        /// Sử dụng cho command timeout trong lớp DataAccess
        /// </summary>
        public static int CmdTimeout = 9000;

        /// <summary>
        /// Biến Global chứa thông tin kết nối Db
        /// </summary>
        /// Host or IpAddress chứa DB
        public static string gHostDB = "127.0.0.1"; //"PC\\MSSQLSERVER2012";

        /// <summary>
        /// Port kết nối đến DB
        /// </summary>
        public static string gPortDB = "1433"; // "1521";

        /// <summary>
        /// ServiceName or Connection_Data của 
        /// </summary>
        public static string gServiceNameDB = "SmartTest";

        /// <summary>
        /// User login vào DB
        /// </summary>
        public static string gUserDB = "demo";

        /// <summary>
        /// Mật khẩu login vào DB
        /// </summary>
        public static string gPwdDB = "demo1234";

        /// <summary>
        /// Trạng thái kết nối
        /// </summary>
        public static bool gConnected = false;

        /// <summary>
        /// Tạo chuỗi kết nối tới DB của Oracle
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="serviceName"></param>
        /// <param name="userName"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public static string GetLoginOracle(string host, string port, string serviceName, string userName, string userPass)
        {
            return "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=" + host + ")(PORT=" + port + "))(CONNECT_DATA=( SERVER = DEDICATED )( SERVICE_NAME=" + serviceName + ")));User Id=" + userName + ";Password=" + userPass + ";";
        }

        /// <summary>
        /// Tạo chuỗi kết nối cho MSSQL
        /// </summary>
        /// <param name="DBHost"></param>
        /// <param name="DBName"></param>
        /// <param name="DBUID"></param>
        /// <param name="DBPwd"></param>
        /// <returns></returns>
        public static string GetLoginMSSQL(string DBHost, string DBName, string DBUID, string DBPwd)
        {
            return "Data Source=" + DBHost + ";Initial Catalog=" + DBName + ";User ID=" + DBUID + "; password=" + DBPwd + "";
        }

        public static string OracleConnectionString = GetLoginOracle(gHostDB, gPortDB, gServiceNameDB, gUserDB, gPwdDB);
        public static string MSSQLConnectionString = GetLoginMSSQL(gHostDB, gServiceNameDB, gUserDB, gPwdDB);


        #endregion

    }
}
