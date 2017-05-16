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
        private string ma { get; set; }
        private DateTime ngaynhap { get; set; }
        private decimal tongtien { get; set; }
        private string nhanvienma { get; set; }

        public static DataTable Get_nhapkho()
        {
            return DAL.DATA.get_nhapkho();
        }

    }
}
