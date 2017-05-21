using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLNL
{
    public partial class Layout_QLNL : UserControl
    {
        public Layout_QLNL()
        {
            InitializeComponent();
        }
        private void Clearpanel2()
        {
            foreach (Control ctrl in panel2.Controls) ctrl.Dispose();
        }
        private void AddControl(Control ctrl)
        {
            Clearpanel2();
            ctrl.Location = new Point(8, 8);
            ctrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel2.Controls.Add(ctrl);
        }
        private void Layout_QLNL_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLNL.UC_NhanVien());
            }
        }

        private void btnKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLNL.UC_KhachHang());
            }
        }
    }
}
