using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLBH.DTO;
namespace QLBH.DAO
{
   public class LopDAO
   {
       DataAccess dataAccess;
       DataTable table;
       DataRow row;
       string sql = "select *from HangHoa";

       public LopDAO()
        {
            dataAccess= new DataAccess();
            table = new DataTable();
        }
       public DataTable Load()
       {
           dataAccess.connect();
           dataAccess.disconnet();
           return table = dataAccess.LoadData(table, dataAccess.adapt(sql)); ;
           
       }
       public void insert(HangHoa hh)
       {
           dataAccess.connect();
           table.Rows.Add(hh.MaMh, hh.TenMh, hh.Dvt, hh.SoLuong, hh.GiaNhap, hh.GiaBan);
           dataAccess.update(dataAccess.adapt(sql), table);
           // string sql = "insert into HangHoa values('"+hh.MaMh+"','"+hh.TenMh+"','"+hh.Dvt+"',"+hh.SoLuong+","+hh.GiaNhap+","+hh.GiaBan+")";
            dataAccess.disconnet();
       }
     
     public DataRow select(int index)
       {
          return row = table.Rows[index];       
       }
       public void delete(int index)
       {
           dataAccess.connect();
           row = table.Rows[index];
           row.Delete();
           dataAccess.update(dataAccess.adapt(sql), table);
           dataAccess.disconnet();
       }
       public void update()
       {
           dataAccess.connect();
           dataAccess.update(dataAccess.adapt(sql), table);
           dataAccess.disconnet();
       }
       public DataTable search()
       {
           return table;
       }
    }
}
