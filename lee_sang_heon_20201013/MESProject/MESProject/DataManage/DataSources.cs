using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MESProject
{
    class DataSources
    {
        private static string strconn =
            "Data Source=192.168.0.19;Initial Catalog=Product"+" Manager;User ID=sa;Password=1234";
        private static SqlConnection conn = null;

        public static SqlConnection getConnection()//메서드실행 - 객체생성 - DB접속
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(strconn);
                }
                conn.Open();
                Console.WriteLine("연결성공");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }

        public static void setClose(SqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    Console.WriteLine("연결끊기성공");
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
