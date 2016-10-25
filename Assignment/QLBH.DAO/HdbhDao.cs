using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLBH.DAO;
using QLBH.DTO;

namespace QLBH.DAO
{
   public class HdbhDao
    { 
     
        DataAccess data = new DataAccess();
        DataTable daTable=new DataTable();
        DataTable daTable1;
        public DataTable loadDuLieu (string dieukien)
        {
            data.connect();
            data.disconnet();
           return daTable=data.LoadData(daTable, data.adapt("select [MÃ MẶT HÀNG], [TÊN MẶT HÀNG], [ĐƠN VỊ TÍNH], [GIÁ BÁN] from HangHoa "+dieukien+""));
        }
       public DataTable saveDuLieu(HoaDon hd)
        {
           daTable1=new DataTable();
            data.connect();
            daTable1 = data.LoadData(daTable1, data.adapt("select *from HD"));
            daTable1.Rows.Add(hd.MaHd,hd.NgayLap);
            data.update(data.adapt("select *from HD"),daTable1);
            data.disconnet();
            return daTable1;
        }
    }
}
