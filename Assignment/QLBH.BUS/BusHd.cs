using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.DAO;
using QLBH.DTO;
using System.Data;
namespace QLBH.BUS
{
   public class BusHd
    {
        HdbhDao hdDao = new HdbhDao();

        public DataTable layDuLieu(string dieukien)
        {
            return hdDao.loadDuLieu(dieukien);
        }
       public DataTable saveDuLieu(HoaDon hd)
        {
           return hdDao.saveDuLieu(hd);
        }
        
    }
}
