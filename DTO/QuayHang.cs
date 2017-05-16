using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace DTO
{
  public  class QuayHang
    {
        private string ma;
        private string ten;

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
        public DataTable get_quayhang()
        {
            return DATA.get_quayhang();
        }

        public int them_quayhang()
        {
            return DATA.them_quayhang(ma, ten);
        }
        public int sua_quayhang()
        {
            return DATA.sua_quayhang(ma, ten);
        }
        public int xoa_quayhang(string ma)
        {
            return DATA.xoa_quayhang(ma);
        }

    }
}
