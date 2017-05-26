using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
    public class NhapKho
    {
        private string ma;
        private DateTime ngaynhap;
        private decimal tongtien;
        private string nhanvienma;

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
        public string NhanVienMa
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
        public DateTime NgayNhap
        {
            get
            {
                return ngaynhap;
            }
            set
            {
                ngaynhap = value;
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
        public static DataTable Get_nhapkho()
        {
            return DAL.DATA.get_nhapkho();
        }
        public void them()
        {
            DATA.them_nhapkho(ma, ngaynhap, tongtien, nhanvienma);
        }
        public void sua()
        {
            DATA.sua_nhapkho(ma, ngaynhap, tongtien, nhanvienma);
        }
        public static DataTable get_nhapkho()
        {
            return DATA.get_nhapkho();
        }
        public static void xoa_nhapkho(string ma)
        {
            DATA.xoa_nhapkho(ma);
        }
        public static DataTable checkmanhapkho(string check)
        {
            return DBConnect.GetData("select 1 from nhapkho where ma ='" + check + "'");
        }
    }
}
