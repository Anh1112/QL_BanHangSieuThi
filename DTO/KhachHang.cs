using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
   public class KhachHang
    {
        private string ma;
        private string ten;
        private string diachi;
        private string sdt;

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
        public DataTable get_khachhang()
        {
            return DATA.get_khachhang();
        }
        public int them()
        {
            return DATA.them_khachhang(ma, ten, diachi, sdt);
        }
        public int sua()
        {
            return DATA.sua_khachhang(ma, ten, diachi, sdt);
        }
        public int xoa(string ma)
        {
            return DATA.xoa_khachhang(ma);
        }
    }
}
