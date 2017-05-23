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
using DAL;

namespace GUI.UC.ThongKe.Detail
{
    public partial class UC_HangTrongKho : UserControl
    {
        public UC_HangTrongKho()
        {
            InitializeComponent();
        }
      //  MatHang mathang = new MatHang();
        private void UC_HangTrongKho_Load(object sender, EventArgs e)
        {
           dgvCTHangTrongKho.DataSource = DTO.MatHang.Get_mathang();
            this.ChartHangTrongKho.Series["Mặt hàng"].XValueMember = "ten";
            this.ChartHangTrongKho.Series["Mặt hàng"].YValueMembers = "soluongtrongkho";
            ChartHangTrongKho.DataSource = DTO.MatHang.Get_mathang();
            ChartHangTrongKho.DataBind();
        }
    }
}