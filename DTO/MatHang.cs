using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DTO
{
    public class MatHang
    {
        private string ma;
        private string ten;
        private string hangsanxuat;
        private string donvitinh;
        private decimal gianhap;
        private decimal giaban;
        private float soluongtrongkho;
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

        public string Hangsanxuat
        {
            get
            {
                return hangsanxuat;
            }

            set
            {
                hangsanxuat = value;
            }
        }

        public string Donvitinh
        {
            get
            {
                return donvitinh;
            }

            set
            {
                donvitinh = value;
            }
        }

        public decimal Gianhap
        {
            get
            {
                return gianhap;
            }

            set
            {
                gianhap = value;
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

        public float Soluongtrongkho
        {
            get
            {
                return soluongtrongkho;
            }

            set
            {
                soluongtrongkho = value;
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
        public static DataTable Get_mathang()
        {
            return DAL.DATA.get_mathang();
        }
        public static DataTable Get_mathang1(string mamh)
        {
            return DAL.DATA.get_mathang1(mamh);
        }
        public int Them()
        {
            return DATA.them_mathang(ma, ten, hangsanxuat, donvitinh, gianhap, giaban, soluongtrongkho, quayma);
        }
        public void Sua()
        {
            DATA.sua_mathang(ma, ten, hangsanxuat, donvitinh, gianhap, giaban, soluongtrongkho, quayma);
        }
        public int Xoa(string mamh)
        {
            return DATA.xoa_mathang(mamh);
        }
    }
}
