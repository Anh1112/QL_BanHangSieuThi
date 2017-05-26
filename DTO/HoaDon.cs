using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
    public class HoaDon
    {
        private string ma;
        private DateTime ngaylap;
        private decimal tongtien;
        private string nhanvienma;
        private string khachhangma;

        public string Ma
        {
            get
            {
                return ma;
            }

            set
            {
                ma = value;
            }
        }

        public DateTime Ngaylap
        {
            get
            {
                return ngaylap;
            }

            set
            {
                ngaylap = value;
            }
        }

        public decimal Tongtien
        {
            get
            {
                return tongtien;
            }

            set
            {
                tongtien = value;
            }
        }

        public string Nhanvienma
        {
            get
            {
                return nhanvienma;
            }

            set
            {
                nhanvienma = value;
            }
        }

        public string Khachhangma
        {
            get
            {
                return khachhangma;
            }

            set
            {
                khachhangma = value;
            }
        }

        public static DataTable Get_hoadon(DateTime tu_ngay, DateTime den_ngay)
        {
            return DAL.DATA.get_hoadon(tu_ngay, den_ngay);
        }

        public static DataTable Get_hoadon()
        {
            return DAL.DATA.get_hoadon();
        }

        public static string Get_maHD()
        {
            int i;
            string ma = "";
            DataTable tb = DAL.DATA.get_mahoadon();
            if(tb.Rows.Count == 1 && int.TryParse(tb.Rows[0].ItemArray[0].ToString(),out i)) ma = string.Format("{0:d10}", i + 1);
            if (ma == "") ma = "0000000001";
            return ma;
        }

        public int Them()
        {
            return DAL.DATA.them_hoadon(ma, ngaylap, tongtien, nhanvienma, khachhangma);
        }

        public int Sua()
        {
            return DAL.DATA.sua_hoadon(ma, ngaylap, tongtien, nhanvienma, khachhangma);
        }

        public static int Xoa(string mahoadon)
        {
            return DAL.DATA.xoa_hoadon(mahoadon);
        }
    }
}
