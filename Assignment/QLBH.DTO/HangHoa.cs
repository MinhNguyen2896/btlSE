using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
        public class HangHoa
    {
        private string maMh;
        private string tenMh;
        private string dvt;
        private int soLuong;
        private float giaNhap;
        private float giaBan;

        public string MaMh
        {
            get { return maMh; }
            set { maMh = value; }
        }
        public string TenMh
        {
            get { return tenMh; }
            set { tenMh = value; }
        }
        public string Dvt
        {
            get { return dvt; }
            set { dvt = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public float GiaNhap
        {
            get { return giaNhap; }
            set { giaNhap = value; }
        }
        public float GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
            public HangHoa ()
        {

        }
        public HangHoa (string mahh,string tenhh,string _dvt,int soluong,float gianhap,float giaban)
        {
            maMh = mahh;
            tenMh = tenhh;
            dvt = _dvt;
            soLuong = soluong;
            giaNhap = gianhap;
            giaBan = giaban;
        }
    }
}
