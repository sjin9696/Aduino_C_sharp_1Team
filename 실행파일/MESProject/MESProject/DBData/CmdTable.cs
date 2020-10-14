using MESProject.DBConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESProject.DBData
{
    class CmdTable
    {
        /*internal void InsertEmp(string name, string age)
        {
            SqlConnection conn = DataSources.getConnection();
            SqlCommand cmd = new SqlCommand("exec proc_emp_insert @name, @age", conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.ExecuteNonQuery();
            DataSources.setClose();
        }*/

        internal DataSet SelectWork()
        {
            SqlConnection conn = DataSources.getConnection();

            // 쿼리문 생성 및 수정필
            SqlCommand cmd = new SqlCommand("exec SelectWorkOrder", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();

            sda.Fill(dataSet);

            DataSources.setClose();

            return dataSet;
        }
    }
}
