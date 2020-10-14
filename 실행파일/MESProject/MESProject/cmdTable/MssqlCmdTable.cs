using MESProject.DBConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MESProject.cmdTable
{
    class MssqlCmdTable
    {
        public DataTable DBSelect() // 김완수
        {
            SqlConnection conn = DataSources.getConnection();
            SqlCommand cmd = new SqlCommand("exec proc_SelectWorkorder", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            DataSources.setClose();

            return ds.Tables[0];
        }
        public void DBInsert(string employeeName, DateTime orderDate, DateTime deliveryDate, //김완수
                    string productName, int productionQuantity, string companyName, string remark)
        {
            SqlConnection conn = DataSources.getConnection();

            SqlCommand cmd = new SqlCommand("exec proc_InsertWorkorder @orderDate," +
                                             "@employeeName, @deliveryDate, @productName, @productionQuantity," +
                                             "@companyName, @remark", conn);

            cmd.Parameters.AddWithValue("@orderDate", orderDate);
            cmd.Parameters.AddWithValue("@employeeName", employeeName);
            cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
            cmd.Parameters.AddWithValue("@productName", productName);
            cmd.Parameters.AddWithValue("@productionQuantity", productionQuantity);
            cmd.Parameters.AddWithValue("@companyName", companyName);
            cmd.Parameters.AddWithValue("@remark", remark);


            cmd.ExecuteNonQuery();
            DataSources.setClose();
        }
    }
}
