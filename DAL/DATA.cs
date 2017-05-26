using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DATA
    {
        #region khachhang
        public static DataTable get_khachhang()
        {
            return DBConnect.GetData("get_khachhang");
        }
        public static int them_khachhang(string ma, string ten, string diachi, string sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_khachhang", para);
        }
        public static int sua_khachhang(string ma, string ten, string diachi, string sdt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_khachhang", para);
        }
        public static int xoa_khachhang(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_khachhang", para);
        }
        #endregion

        #region hoadon
        public static DataTable get_hoadon(DateTime tu_ngay, DateTime den_ngay)
        {
            return DBConnect.GetData("select hoadon.ma as [Mã hóa đơn], khachhang.ten as [Tên khách hàng], ngaylap as [Ngày lập], tongtien as [Tổng tiền], nhanvienma as [Mã NV bán hàng]  from hoadon join khachhang on hoadon.khachhangma = khachhang.ma where ngaylap >= " + string.Format("'{0}-{1}-{2}'", tu_ngay.Year, tu_ngay.Month, tu_ngay.Day) + " and ngaylap <= " + string.Format("'{0}-{1}-{2}'", den_ngay.Year, den_ngay.Month, den_ngay.Day));
        }
        public static DataTable get_mahoadon()
        {
            return DBConnect.GetData("select max(ma) from hoadon");
        }
        public static DataTable get_hoadon()
        {
            return DBConnect.GetData("get_hoadon");
        }
        public static int them_hoadon(string ma, DateTime ngaylap, decimal tongtien, string nhanvienma, string khachhangma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ngaylap",(ngaylap.Year!=1000)?(object)ngaylap:DBNull.Value),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value),
                new SqlParameter("@nhanvienma",(nhanvienma!=null && nhanvienma.Trim()!="")?(object)nhanvienma:DBNull.Value),
                new SqlParameter("@khachhangma",(khachhangma!=null && khachhangma.Trim()!="")?(object)khachhangma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_hoadon", para);
        }
        public static int sua_hoadon(string ma, DateTime ngaylap, decimal tongtien, string nhanvienma, string khachhangma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ngaylap",(ngaylap.Year!=1000)?(object)ngaylap:DBNull.Value),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value),
                new SqlParameter("@nhanvienma",(nhanvienma!=null && nhanvienma.Trim()!="")?(object)nhanvienma:DBNull.Value),
                new SqlParameter("@khachhangma",(khachhangma!=null && khachhangma.Trim()!="")?(object)khachhangma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("sua_hoadon", para);
        }
        public static int xoa_hoadon(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_hoadon", para);
        }
        #endregion

        #region nhanvien
        public static DataTable get_nhanvien()
        {
            return DBConnect.GetData("get_nhanvien");
        }
        public static int them_nhanvien(string ma, string ten, string diachi, string sdt, string chucvu, DateTime ngaysinh, decimal luong, string quayma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh!=null && ngaysinh.Year>1800)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@chucvu",(chucvu!=null && chucvu.Trim()!="")?(object)chucvu:DBNull.Value),
                new SqlParameter("@luong",(luong>0)?(object)luong:DBNull.Value),
                new SqlParameter("@quayma",(quayma!=null && quayma.Trim()!="")?(object)quayma:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("them_nhanvien", para);
        }
        public static int sua_nhanvien(string ma, string ten, string diachi, string sdt, string chucvu, DateTime ngaysinh, decimal luong, string quayma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
                new SqlParameter("@ngaysinh",(ngaysinh!=null && ngaysinh.Year>1800)?(object)ngaysinh:DBNull.Value),
                new SqlParameter("@sdt",(sdt!=null && sdt.Trim()!="")?(object)sdt:DBNull.Value),
                new SqlParameter("@diachi",(diachi!=null && diachi.Trim()!="")?(object)diachi:DBNull.Value),
                new SqlParameter("@chucvu",(chucvu!=null && chucvu.Trim()!="")?(object)chucvu:DBNull.Value),
                new SqlParameter("@luong",(luong>0)?(object)luong:DBNull.Value),
                new SqlParameter("@quayma",(quayma!=null && quayma.Trim()!="")?(object)quayma:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("sua_nhanvien", para);
        }
        public static int xoa_nhanvien(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_nhanvien", para);
        }

        #endregion

        #region quayhang
        public static DataTable get_quayhang()
        {
            return DBConnect.GetData("get_quayhang");
        }
        public static int them_quayhang(string ma, string ten)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("them_quayhang", para);
        }
        public static int sua_quayhang(string ma, string ten)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ten",(ten!=null && ten.Trim()!="")?(object)ten:DBNull.Value),
            };
            return DBConnect.ExecuteNonQuery("sua_quayhang", para);
        }
        public static int xoa_quayhang(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_quayhang", para);
        }
        #endregion

        #region nhapkho
        public static DataTable get_nhapkho()
        {
            return DBConnect.GetData("get_nhapkho");
        }

        public static int them_nhapkho(string ma, DateTime ngaynhap, decimal tongtien, string nhanvienma)
        {
            string temp =ngaynhap.ToShortDateString();

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",ma),
                new SqlParameter("@ngayxuat",ngaynhap),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value),
                new SqlParameter("@nvma",(nhanvienma!=null && nhanvienma.Trim()!="")?(object)nhanvienma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_nhapkho", para);
        }
        public static int sua_nhapkho(string ma, DateTime ngaynhap, decimal tongtien, string nhanvienma)

        {
            SqlParameter[] para = new SqlParameter[]
            {
               
                 new SqlParameter("@ma",ma),
                new SqlParameter("@ngayxuat","'"+ngaynhap+"'"),
                new SqlParameter("@tongtien",(tongtien>0)?(object)tongtien:DBNull.Value),
                new SqlParameter("@nvma",(nhanvienma!=null && nhanvienma.Trim()!="")?(object)nhanvienma:DBNull.Value)
      };
            return DBConnect.ExecuteNonQuery("sua_nhapkho", para);
        }
        public static int xoa_nhapkho(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@ma",ma)
           };
            return DBConnect.ExecuteNonQuery("xoa_nhapkho", para);
        }
        #endregion

        #region chitietnhapkho
        // thong ke luu luong nhap hang cua tat ca cac loai hang hoa
        public static DataTable get_chitietnhapkho(string ma)
        {
            return DBConnect.GetData("get_chitietnhapkho '" + ma + "'");
        }


        // thong ke luu luong nhap cua tung hang hoa
        public static DataTable get_chitietnhapsanpham(string nhapkhoma, string mathangma)
        {
            return DBConnect.GetData("get_chitietnhapsanpham '" + nhapkhoma + "'" + "'" + mathangma + "'");
        }
        public static int them_chitietnhapkho(string mamh, string mank, float sl, decimal gn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mamh",mamh),
                new SqlParameter("@mank",mank),
                new SqlParameter("@sl",(sl>0)?(object)sl:DBNull.Value),
                new SqlParameter("@gn",(gn>0 ?(object)gn:DBNull.Value))
            };
            return DBConnect.ExecuteNonQuery("them_chitietnhapkho", para);
        }
        public static int sua_chitietnhapkho(string mamh, string mank, float sl, decimal gn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mamh",mamh),
                new SqlParameter("@mank",mank),
                new SqlParameter("@sl",(sl>0)?(object)sl:DBNull.Value),
                new SqlParameter("@gn",(gn>0 ?(object)gn:DBNull.Value))
            };
            return DBConnect.ExecuteNonQuery("sua_chitietnhapkho", para);
        }
        public static int xoa_chitietnhapkho(string mamh, string mank)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                 new SqlParameter("@mamh",mamh),
                  new SqlParameter("@mank",mank)
           };
            return DBConnect.ExecuteNonQuery("xoa_chitietnhapkho", para);
        }
        #endregion

        #region mathang
        public static DataTable get_mathang()
        {
            return DBConnect.GetData("get_mathang");
        }
        public static DataTable get_mathang1(string mamh)
        {
            return DBConnect.GetData("get_mathang '" + mamh + "'");
        }
        public static int them_mathang(
            string ma,
            string ten,
            string hangsanxuat,
            string donvitinh,
            decimal gianhap,
            decimal giaban,
            float soluongtrongkho,
            string quayma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@hangsanxuat", hangsanxuat),
                new SqlParameter("@donvitinh", donvitinh),
                new SqlParameter("@gianhap", gianhap),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@soluongtrongkho",(soluongtrongkho>0)?(object)soluongtrongkho:DBNull.Value),
                new SqlParameter("@quayma",(quayma!=null && quayma.Trim()!="")?(object)quayma:DBNull.Value)
            };
            return DBConnect.ExecuteNonQuery("them_mathang", para);
        }
        public static int sua_mathang(
            string ma,
            string ten,
            string hangsanxuat,
            string donvitinh,
            decimal gianhap,
            decimal giaban,
            float soluongtrongkho,
            string quayma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma),
                new SqlParameter("@ten", ten),
                new SqlParameter("@hangsanxuat", hangsanxuat),
                new SqlParameter("@donvitinh", donvitinh),
                new SqlParameter("@gianhap", gianhap),
                new SqlParameter("@giaban", giaban),
                new SqlParameter("@soluongtrongkho",(soluongtrongkho>0)?(object)soluongtrongkho:DBNull.Value),             
                new SqlParameter("@quayma",(quayma!=null && quayma.Trim()!="")?(object)quayma:DBNull.Value)
               
            };
            return DBConnect.ExecuteNonQuery("sua_mathang", para);
        }
        public static int xoa_mathang(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma", ma)
            };
            return DBConnect.ExecuteNonQuery("xoa_mathang", para);
        }
        #endregion

        #region chitiethoadon
        // thong ke luong hang ban ra cua moi mot san pham nhat dinh
        public static DataTable get_chitietbansanpham(string mahoadon, string mathangma)
        {
            return DBConnect.GetData("get_chitietbansanpham '" + mahoadon + "'" + "'" + mathangma + "'");
        }
        // thong ke luong hang ban ra cua tung san pham
        public static DataTable get_chitiethoadon(string mahoadon)
        {
            return DBConnect.GetData("get_chitiethoadon '" + mahoadon + "'");
        }
        public static int them_chitiethoadon(
            string mathangma,
            string hoadonma,
            double soluong,
            decimal giaban)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathangma", mathangma),
                new SqlParameter("@hoadonma", hoadonma),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@giaban", giaban)
            };
            return DBConnect.ExecuteNonQuery("them_chitiethoadon", para);
        }
        public static int sua_chitiethoadon(
            string mathangma,
            string hoadonma,
            double soluong,
            decimal giaban)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathangma", mathangma),
                new SqlParameter("@hoadonma", hoadonma),
                new SqlParameter("@soluong", soluong),
                new SqlParameter("@giaban", giaban)
            };
            return DBConnect.ExecuteNonQuery("sua_chitiethoadon", para);
        }
        public static int xoa_chitiethoadon(string mathangma, string hoadonma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mathangma", mathangma),
                new SqlParameter("@hoadonma", hoadonma)
            };
            return DBConnect.ExecuteNonQuery("xoa_chitiethoadon", para);
        }
        #endregion
    }
}
