using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
   public  class ChiTietNhapKho
    {
        private string mathangma { get; set; }
        private string nhapkhoma { get; set; }
        private float soluong { get; set; }
        private decimal gianhap { get; set; }

        public static DataTable Get_chitietnhapkho(string ma)
        {
            return DAL.DATA.get_chitietnhapkho(ma);
        }
        public static DataTable Get_chitietnhapsanpham(string nkma, string mhma)
        {
            return DAL.DATA.get_chitietnhapsanpham(nkma, mhma);
        }
    }
}
