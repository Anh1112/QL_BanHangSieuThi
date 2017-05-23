using GUI.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.UC.QLNH
{

    public partial class changenk : Form
    {
        public delegate void changesnk();
        public event changesnk saveclick;
        public bool change = false;
        private bool drag = false;
        private Point dragCursor, dragForm;
        public changenk()
        {
           // dtv.DataSource = DATA.get_nhanvien();
            InitializeComponent();
            //cbb_nvma.DataSource = dtv.Columns[0];
            cbb_nvma.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_chedo.Text = "Thêm";
        }
        public changenk(NhapKho nk)
        {
            InitializeComponent();
            txt_ma.Text = nk.Ma.ToString();
            time_ngaynhap.Value = nk.NgayNhap;
            cbb_nvma.Text = nk.NhanVienMa;
            txt_money.Text = nk.Tongtien.ToString();
            cbb_nvma.Enabled = false;
            lbl_chedo.Text = "Sửa";
        }

        private void changenk_Load(object sender, EventArgs e)
        {
            if(change==true)
            {
                txt_ma.Enabled = false;
            }
            btn_luu.Click += btncliclk;
        }

        private void btncliclk(object sender, EventArgs e)
        {
            if (change == false)
            {
               // for(var i in d)
                if(txt_ma.Text.Trim() != "")
                {
                    DATA.them_nhapkho(txt_ma.Text, DateTime.Parse(time_ngaynhap.Value.ToShortDateString()), decimal.Parse(txt_money.Text), cbb_nvma.Text);
                }
               
            }
            else
            {
                DATA.sua_nhapkho(txt_ma.Text, DateTime.Parse(time_ngaynhap.Value.ToShortDateString()), decimal.Parse(txt_money.Text), cbb_nvma.Text);
            }
            btn_luu.Actived = false;
            if (saveclick!=null)
            saveclick();
        }

        private void btnSimple1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void changenk_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void mouseup(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void changenk_MouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                // Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                // QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }

        private void ts_Tick(object sender, EventArgs e)
        {
            if(lbl_chedo.ForeColor == Color.FromName("HOTPINK"))
            {
                lbl_chedo.ForeColor = Color.FromName("FUCHSIA");
            }
            else if(lbl_chedo.ForeColor == Color.FromName("FUCHSIA"))
            {
                lbl_chedo.ForeColor = Color.FromName("DEEPPINK");
            }
            else
            {
                lbl_chedo.ForeColor = Color.FromName("HOTPINK");
            }
        }

        private void btn_huy_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnSimple2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
