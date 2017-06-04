using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.TroGiup
{
    public partial class UC_GioiThieu : UserControl
    {
        public UC_GioiThieu()
        {
            InitializeComponent();
        }

        private void UC_GioiThieu_Load(object sender, EventArgs e)
        {

        }

        private void llbQLHH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblQLHH.Visible = true;
            lblThongKe.Visible = false;
            lblQLNS.Visible = false;
            lblQLNH.Visible = false;
            lblQLBH.Visible = false;
        }

        private void llbQLNH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblQLNH.Visible = true;
            lblQLBH.Visible = false;
            lblQLHH.Visible = false;
            lblThongKe.Visible = false;
            lblQLNS.Visible = false;
        }

        private void llbQLBH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblQLBH.Visible = true;
            lblQLHH.Visible = false;
            lblThongKe.Visible = false;
            lblQLNS.Visible = false;
            lblQLNH.Visible = false;
        }

        private void llbQLNS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblQLNS.Visible = true;
            lblQLBH.Visible = false;
            lblQLHH.Visible = false;
            lblThongKe.Visible = false;
            lblQLNH.Visible = false;
        }

        private void llbThongKe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblThongKe.Visible = true;
            lblQLNS.Visible = false;
            lblQLBH.Visible = false;
            lblQLHH.Visible = false;
            lblQLNH.Visible = false;
        }
    }
}
