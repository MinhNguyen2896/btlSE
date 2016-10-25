using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLBH.DAO
{
   public class DataAccess
    {
        public const string str=@"Data Source=MINHNGUYEN-PC\SQLEXPRESS;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public DataAccess()
        {
            con = new SqlConnection(str);
        }
        public void connect()
        {
            con.Open();
        }
        public void disconnet()
        {
            con.Close();
        }
        public void ExecuteNonquery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
       public string ExecuteReader(string sqlTr)
        {
            string temp = null;
            connect();
            cmd = new SqlCommand(sqlTr, con);
           SqlDataReader reader=cmd.ExecuteReader();
           while (reader.Read())
           {
               temp = sqlTr[0].ToString();
           }
           disconnet();
           return temp;
        }
       public SqlDataAdapter adapt(string sql)
       {
           SqlDataAdapter adapt = new SqlDataAdapter(sql, con);
           return adapt;
       }
       public DataTable LoadData(DataTable data, SqlDataAdapter adapt)
       {
           adapt.Fill(data);
           return data;
       }
       public void update(SqlDataAdapter adapt,DataTable table)
       {

           SqlCommandBuilder buil = new SqlCommandBuilder(adapt);
           adapt.Update(table);
       }
    }
}
