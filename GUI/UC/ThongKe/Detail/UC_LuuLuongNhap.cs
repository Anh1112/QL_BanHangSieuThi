using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI.UC.ThongKe.Detail
{
    public partial class UC_LuuLuongNhap : UserControl
    {
        public UC_LuuLuongNhap()
        {
            InitializeComponent();
        }

        //
        private void UC_LuuLuongNhap_Load(object sender, EventArgs e)
        {
            //dgvCTHangTrongKho.DataSource = DTO.MatHang.Get_mathang();
            cbbMaNhapKho.DataSource = DTO.NhapKho.Get_nhapkho();
            cbbMaNhapKho.DisplayMember = "Mã";
            cbbMaNhapKho.ValueMember = "Mã";
            dgvLuuLuongNhapHang.DataSource = DTO.ChiTietNhapKho.Get_chitietnhapkho(cbbMaNhapKho.Text);            
        }
     //   MatHang mathang = new MatHang();
        private void btnLoad_MouseClick(object sender, MouseEventArgs e)
        {
            this.ChartHangTrongKho.Series["Mặt hàng"].XValueMember = "ten";
            this.ChartHangTrongKho.Series["Mặt hàng"].YValueMembers = "soluongtrongkho";
            //  ChartHangTrongKho.DataSource = mathang.Get_mathang();
            ChartHangTrongKho.DataSource = DTO.MatHang.Get_mathang1(cbbMaNhapKho.Text);
            ChartHangTrongKho.DataBind();
        }
    }
}
