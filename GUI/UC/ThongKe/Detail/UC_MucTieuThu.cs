using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.ThongKe.Detail
{
    public partial class UC_MucTieuThu : UserControl
    {
        public UC_MucTieuThu()
        {
            InitializeComponent();
        }

        private void UC_MucTieuThu_Load(object sender, EventArgs e)
        {
            cbbHoaDon.DataSource = DTO.HoaDon.Get_hoadon();
            cbbHoaDon.DisplayMember = "Mã";
            cbbHoaDon.ValueMember = "Mã";
            dgvMucTieuThu.DataSource = DTO.ChiTietHoaDon.Get_chitiethoadon(cbbHoaDon.Text);
        }

        private void btnLoad_MouseClick(object sender, MouseEventArgs e)
        {
            this.chartMucTieuThu.Series["Mặt hàng"].XValueMember = "ten";
            this.chartMucTieuThu.Series["Mặt hàng"].YValueMembers = "soluong";
            chartMucTieuThu.DataSource = DTO.ChiTietHoaDon.Get_chitiethoadon(cbbHoaDon.Text);
            chartMucTieuThu.DataBind();
        }
    }
}
