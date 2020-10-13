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
        // 이상헌 mssql과 연동되어 SelectWorkOrder 프로시져 조회
        public DataTable doDataTable(DateTime dt1, DateTime dt2, string combotext, string text)
        {
            
            SqlCommand cmd = new SqlCommand("exec SelectCTL @combotext, @boxtext, @t_end, @t_start", DataSources.getConnection());
            cmd.Parameters.AddWithValue("@combotext", combotext);
            cmd.Parameters.AddWithValue("@boxtext", text);
            cmd.Parameters.AddWithValue("@t_end", dt2);
            cmd.Parameters.AddWithValue("@t_start", dt1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            sda.Fill(ds);

            return ds.Tables[0];
        }
    }
}
