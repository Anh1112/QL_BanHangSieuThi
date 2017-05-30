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


                //ChartHangTrongKho.ChartAreas["ChartAreas1"].AxisX.Title = "Mặt hàng";
                //ChartHangTrongKho.ChartAreas["ChartAreas2"].AxisX.Title = "Số lượng";

                this.ChartHangTrongKho.Series["Mặt hàng"].XValueMember = "Tên hàng";
                this.ChartHangTrongKho.Series["Mặt hàng"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                this.ChartHangTrongKho.Series["Mặt hàng"].YValueMembers = "Số lượng trong kho";
                this.ChartHangTrongKho.Series["Mặt hàng"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                ChartHangTrongKho.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kho rỗng");
            }


            // ChartHangTrongKho.DataBind();
        }
    }
}