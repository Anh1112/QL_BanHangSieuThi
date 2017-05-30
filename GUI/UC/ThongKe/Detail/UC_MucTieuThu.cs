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
            dgvMucTieuThu.DataSource = DTO.ChiTietHoaDon.Get_muctieuthu_theongay (dtpTuNgay.Value , dtpDenNgay.Value);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            UC_MucTieuThu_Load(sender, e);
        }
    }
}


