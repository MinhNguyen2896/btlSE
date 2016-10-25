using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
   public class HoaDon
    {
        private string maHd;
       private DateTime ngayLap;
       public string MaHd
       {
           get { return maHd; }
           set { maHd = value; }
       }
       public DateTime NgayLap
       {
           get { return ngayLap; }
           set { ngayLap = value; }
       }
       public HoaDon(string mahd,DateTime ngaylap)
       {
           maHd = mahd;
           ngayLap = ngaylap;
       }
       
    }
}
