using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.UC.TimKiem
{
    public partial class LayoutTimKiem : UserControl
    {
        public LayoutTimKiem()
        {
            InitializeComponent();
        }
        MatHang mh = new MatHang();

        void HienThi_MatHang()
        {
            // DataTable dt = mh.Get_mathang();
            DataTable dt = DTO.MatHang.Get_mathang();
            dgvTimKiem.DataSource = dt;
        }

        void TimKiem()
        {
            DataTable dt = new DataTable();
            dt = DAL.DBConnect.GetData(@"select	ma as [Mã hàng], 
			ten as [Tên hàng], 
			hangsanxuat as [Hãng sản xuất],
			donvitinh as [Đơn vị],
			gianhap as [Giá nhập],
			giaban as [Giá bán],
			soluongtrongkho as [Số lượng trong kho],
			quayma as [Mã quầy] from mathang where ten like '%" + txtSearch.Text.Trim() + "%' or hangsanxuat like '%"+ txtSearch.Text.Trim() + "%' or giaban like  '%" + txtSearch.Text.Trim() + "%'");
            dgvTimKiem.DataSource = dt;      
        }

        private void LayoutTimKiem_Load(object sender, EventArgs e)
        {
            HienThi_MatHang();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
