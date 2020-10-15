using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESProject
{
    class MainDataSource
    {

        //table 조회기능
        public DataTable doDataTable(DateTime dt1, DateTime dt2, string combotext, string text)
        {
            DataSet ds = new DataSet();
            SqlConnection conn = DataSources.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("exec Selecttest @combotext, @boxtext, @t_end, @t_start", conn);
                cmd.Parameters.AddWithValue("@combotext", combotext);
                cmd.Parameters.AddWithValue("@boxtext", text);
                cmd.Parameters.AddWithValue("@t_end", dt2);
                cmd.Parameters.AddWithValue("@t_start", dt1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                return null;
            }
            finally {
                DataSources.setClose(conn);
            }
            return ds.Tables[0];
        }
    }
}
