using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DTO
{
   public  class ChiTietNhapKho
    {
        private string nhapkhoma;
        private string mathangma;
        private float soluong;
        private decimal giaban;
        public string MatHangMa
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
        public string NhapKhoMa { get { return nhapkhoma; } set { nhapkhoma = value; } }
        public float soLuong { get { return soluong; } set {soluong=value; } }
        public decimal Giaban { get { return giaban; } set { giaban = value; } }

        public static DataTable Get_chitietnhapkho(string ma)
        {
            return DAL.DATA.get_chitietnhapkho(ma);
        }
        public static DataTable Get_chitietnhapsanpham(string nkma, string mhma)
        {
            return DAL.DATA.get_chitietnhapsanpham(nkma, mhma);
        }
        public int them()
        {
          return  DATA.them_chitietnhapkho(mathangma, nhapkhoma, soluong, giaban);
        }
        public void sua()
        {
            DATA.sua_chitietnhapkho(mathangma, nhapkhoma, soluong, giaban);
        }

        public static void xoa(string mathangma,string nhapkhoma)
        {
            DATA.xoa_chitietnhapkho(mathangma, nhapkhoma);
        }
        public static DataTable getmanotinchitiet(string ma)
        {
            return DATA.giamachuacoCT(ma);
        }
    }
}
