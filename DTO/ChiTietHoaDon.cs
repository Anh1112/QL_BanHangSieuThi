using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private string mathangma;
        private string hoadonma;
        private float soluong;
        private decimal giaban;

        public string Mathangma
        {
            get
            {
                return mathangma;
            }

            set
            {
                mathangma = value;
            }
        }

        public string Hoadonma
        {
            get
            {
                return hoadonma;
            }

            set
            {
                hoadonma = value;
            }
        }

        public float Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public decimal Giaban
        {
            get
            {
                return giaban;
            }

            set
            {
                giaban = value;
            }
        }

        public static DataTable Get_chitietbansanpham(string maHD, string mhma)
        {
            return DAL.DATA.get_chitietbansanpham(maHD, mhma);
        }
        public static DataTable Get_chitiethoadon(string maHD)
        {
            return DAL.DATA.get_chitiethoadon(maHD);
        }
        public int Them()
        {
            return DAL.DATA.them_chitiethoadon(mathangma, hoadonma, soluong, giaban);
        }
        public int Sua()
        {
            return DAL.DATA.sua_chitiethoadon(mathangma, hoadonma, soluong, giaban);
        }
        public int Xoa()
        {
            return DAL.DATA.xoa_chitiethoadon(mathangma, hoadonma);
        }
    }
}
