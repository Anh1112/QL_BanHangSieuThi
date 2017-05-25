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
        public delegate void changeCnk();
        public event changeCnk saveclick;
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
            txt_ma.Text = layma();
            DataTable dt = new DataTable();
            dt = DBConnect.GetData("select ma from nhanvien");
            if (dt != null)
                cbb_nvma.DataSource = dt;
            cbb_nvma.DisplayMember = "ma";
            cbb_nvma.ValueMember = "ma";
        }
        public changenk(NhapKho nk)
        {
            InitializeComponent();
            txt_ma.Text = nk.Ma.ToString();
            time_ngaynhap.Value = nk.NgayNhap;
            cbb_nvma.Text = nk.NhanVienMa;
          //  txt_money.Text = nk.Tongtien.ToString();
            cbb_nvma.Enabled = false;
            lbl_chedo.Text = "Sửa";
            cbb_nvma.Text = nk.NhanVienMa;
           
        }
        private string layma()
        {
            DataTable dt = new DataTable();
            string check;
            do
            {
                Random rd = new Random();
                int temp = rd.Next(99999999);
                check = "NK" + temp.ToString();
                dt = DBConnect.GetData("select 1 from nhapkho where ma ='" + check + "'");
            } while (dt == null);
            return check;
        }
        private void changenk_Load(object sender, EventArgs e)
        {
           
                txt_ma.Enabled = false;
            btn_luu.Click += btncliclk;
        }

        private void btncliclk(object sender, EventArgs e)
        {
            NhapKho nk = new NhapKho();
            nk.Ma = txt_ma.Text;
            nk.NgayNhap = time_ngaynhap.Value;
          //  if (txt_money.Text != "")
          //      nk.Tongtien = decimal.Parse(txt_money.Text);
          //  else
                nk.Tongtien = 0;
            if (cbb_nvma.Text != "")
                nk.NhanVienMa = cbb_nvma.Text;
            else
                nk.NhanVienMa = "notDL";

            if (change == false)
            {
                nk.them();
            }
            else
            {
                nk.sua();
            }
            btn_luu.Actived = false;
            if (saveclick!=null)
            {
                saveclick();
                txt_ma.Text = layma();
            }
           
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
