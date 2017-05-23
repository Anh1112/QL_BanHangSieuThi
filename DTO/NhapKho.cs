using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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

    }
}
