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
            
        }
        //   MatHang mathang = new MatHang();
        private void btnLoad_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ChartHangTrongKho.Visible = true;
                dgvLuuLuongNhapHang.Visible = true;
                dgvLuuLuongNhapHang.DataSource = DTO.ChiTietNhapKho.Get_luuluongnhap_theongay(dtpTuNgay.Value, dtpDenNgay.Value);
                ChartHangTrongKho.DataSource = DTO.ChiTietNhapKho.Get_luuluongnhap_theongay(dtpTuNgay.Value, dtpDenNgay.Value);
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueMember = "Sản phẩm";
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                this.ChartHangTrongKho.Series["Mặt hàng"].YValueMembers = "SL";
                this.ChartHangTrongKho.Series["Mặt hàng"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                ChartHangTrongKho.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có thông tin nhập hàng");
            }
        }
    }
}
