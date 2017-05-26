using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
   public class NhanVien
    {
        private string ma;
        private string ten;
        private string diachi;
        private string sdt;
        private string chucvu;
        private DateTime ngaysinh;
        private decimal luong;
        private string quayma;

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

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Diachi
        {
            get
            {
                return diachi;
            }

            set
            {
                diachi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return chucvu;
            }

            set
            {
                chucvu = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public decimal Luong
        {
            get
            {
                return luong;
            }

            set
            {
                luong = value;
            }
        }

        public string Quayma
        {
            get
            {
                return quayma;
            }

            set
            {
                quayma = value;
            }
        }
        public DataTable get_nhanvien()
        {
            return DATA.get_nhanvien();
        }

        public int them_nhanvien()
        {
            return DATA.them_nhanvien(ma, ten, diachi,sdt, chucvu, ngaysinh, luong, quayma);
        }
        public int sua_nhanvien()
        {
            return DATA.sua_nhanvien(ma, ten, diachi, sdt, chucvu, ngaysinh,  luong, quayma);
        }
        public int xoa_nhanvien(string ma)
        {
            return DATA.xoa_nhanvien(ma);
        }
        public static DataTable get_manhanvien()
        {
            return DBConnect.GetData("select ma from nhanvien");
        }
    }
}
