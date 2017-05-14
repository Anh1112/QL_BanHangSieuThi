using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Class;

namespace GUI
{
    public partial class FormMain : Form
    {
        //Mouse_Position mouse_point = Mouse_Position.None;
        public FormMain()
        {
            //DTO.Connect.SetConnectString(Application.StartupPath.Replace(@"bin\Debug", @"data\SieuThi.mdf"));
            //while (!DTO.Connect.Open() && MessageBox.Show("Can not connect DataBase", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ;
            //MessageBox.Show(DTO.Connect.GetSqlConnection().State.ToString());
            InitializeComponent();
        }

        private void btnMenu_MouseClick(object sender, MouseEventArgs e)
        {

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
        private void btnTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.TimKiem.LayoutTimKiem());
            }
        }

        private void btnQLHH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLHH.LayoutQLHH());
            }
        }

        private void btnQLNH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLNH.LayoutQLNH());
            }
        }

        private void btnQLBH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLBH.LayoutQLBH());
            }
        }

        private void btnQLNL_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.QLNL.Layout_QLNL());
            }
        }

        private void btnTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.ThongKe.LayoutThongKe());
            }
        }

        private void btnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.WindowState == FormWindowState.Normal) { MaximizedBounds = Screen.PrimaryScreen.WorkingArea; this.WindowState = FormWindowState.Maximized; btnMaximize.Text = "2"; this.Padding = new Padding(0); }
                else { this.WindowState = FormWindowState.Normal; btnMaximize.Text = "1"; this.Padding = new Padding(1); }
            }
        }

        private void btnClose_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Close();
        }

        private void ToolBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTroGiup_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AddControl(new UC.TroGiup.LayoutTroGiup());
            }
        }
    }
}
