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
    public partial class UC_HangTrongKho : UserControl
    {
        public UC_HangTrongKho()
        {
            InitializeComponent();
        }
      //  MatHang mathang = new MatHang();
        private void UC_HangTrongKho_Load(object sender, EventArgs e)
        {
          try
            {
                dgvCTHangTrongKho.DataSource = DTO.MatHang.Get_mathang();
                ChartHangTrongKho.DataSource = DTO.MatHang.Get_mathang();
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueMember = "ten";
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                this.ChartHangTrongKho.Series["Mặt hàng"].YValueMembers = "soluongtrongkho";
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Kho rỗng");
            }


           // ChartHangTrongKho.DataBind();
        }
    }
}