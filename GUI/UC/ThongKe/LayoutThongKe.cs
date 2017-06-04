using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.ThongKe
{
    public partial class LayoutThongKe : UserControl
    {
        public LayoutThongKe()
        {
            InitializeComponent();
        }

        private void ClearRenderbody()
        {
            foreach (Control ctrl in RenderBody.Controls) ctrl.Dispose();
        }
        private void AddControl(Control ctrl)
        {
            ClearRenderbody();
            ctrl.Location = new Point(8, 8);
            ctrl.Width = RenderBody.Width - 16;
            ctrl.Height = RenderBody.Height - 16;
            ctrl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            RenderBody.Controls.Add(ctrl);
        }
        private void btnHangTrongKho_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.ThongKe.Detail.UC_HangTrongKho());
            }
        }

        private void btnTKBan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.ThongKe.Detail.UC_MucTieuThu());
            }
        }

        private void btnNhap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.ThongKe.Detail.UC_LuuLuongNhap());
            }
        }
    }
}
