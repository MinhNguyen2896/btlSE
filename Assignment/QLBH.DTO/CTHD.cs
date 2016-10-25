using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
   public class CTHD
    {
        private string maHd;
        private string maMh;
        private int soLuong;
        private float chietKhau;
        private float thanhTien;
        public string MaHd
        {
            get { return maHd; }
            set { maHd = value; }
        }

        public float ChietKhau
        {
            get { return chietKhau; }
            set { chietKhau = value; }
        }
       
        public string MaMh
        {
            get { return maMh; }
            set { maMh = value; }
        }
     
       
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    
        public CTHD (string mahd,string mamh,int soluong,float chietkhau,float thanhtien)
        {
            maHd = mahd;
            maMh = mamh;
            soLuong = soluong;
            chietKhau = chietkhau;
            thanhTien=thanhtien;
            
        }
    }
}
