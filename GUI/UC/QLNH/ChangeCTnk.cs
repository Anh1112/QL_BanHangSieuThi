using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLNH
{
    public partial class ChangeCTnk : Form
    {
        public bool change = false;
        private bool drag = false;
        private Point dragCursor, dragForm;
        public delegate void changeCTnk();
        public event changeCTnk saveCTclick;
        public ChangeCTnk(string nkma)
        {
            InitializeComponent();
            lbl_chedo.Text = "Thêm";
            txt_mank.Text = nkma;
        }
        private void btncliclk(object sender, EventArgs e)
        {
            ChiTietNhapKho nk = new ChiTietNhapKho();
            string temp="";
            {
                if((cbb_mahang.SelectedValue!= null))
                    {
                    if (cbb_mahang.SelectedValue.ToString().CompareTo((cbb_mahang.Text)) != 0)
                    {
                        temp = "Mặt Hàng";
                    }
                }
                else
                    temp = "Mặt Hàng";


            }
                
            
            float temp2;
           if( float.TryParse(txt_soluong.Text,out temp2)==false)
            {
                if (temp == "")
                {
                    temp = "Số Lượng";
                }
                else
                    temp += ",Số Lượng";
            }
            decimal temp3;
            if (decimal.TryParse(txt_gianhap.Text, out temp3) == false)
            {
                if (temp == "")
                {
                    temp = "Giá Bán";
                }
                else
                    temp += ",Giá Bán";
            }
            if(temp=="")
            {
                nk.NhapKhoMa = txt_mank.Text;
                nk.MatHangMa = cbb_mahang.Text;
                nk.Giaban = temp3;
                nk.soLuong = temp2;
                if (change == false)
                {
                    nk.them();
                    DataTable dt = new DataTable();
                    dt = DATA.laymachuacoCT(txt_mank.Text);
                    cbb_mahang.DataSource = dt;
                    cbb_mahang.DisplayMember = "ma";
                    cbb_mahang.ValueMember = "ma";
                }
                else
                {
                    nk.sua();
                    this.Close();
                }

                btn_luu.Actived = false;
                if (saveCTclick != null)
                {
                    saveCTclick();
                }
            }
            else
            {
                MessageBox.Show("Bạn Cần xem lại các ô " + temp);
            }

        }
        public ChangeCTnk(ChiTietNhapKho ct)
        {
            InitializeComponent();
            cbb_mahang.Text = ct.MatHangMa;
            txt_mank.Text = ct.NhapKhoMa;
            txt_gianhap.Text = ct.Giaban.ToString();
            txt_soluong.Text = ct.soLuong.ToString();
            lbl_chedo.Text = "Sửa";
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
        private void ChangeCTnk_Load(object sender, EventArgs e)
        {
            ts.Start();
            txt_mank.Enabled = false;
            btn_luu.Click += btncliclk;
            if (change == false)
            {
                DataTable dt = new DataTable();
                dt = DATA.laymachuacoCT(txt_mank.Text);
                cbb_mahang.DataSource = dt;
                cbb_mahang.DisplayMember = "ma";
                cbb_mahang.ValueMember = "ma";
                
            }
        }

        private void btnSimple1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnSimple2_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSimple4_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ts_Tick(object sender, EventArgs e)
        {
            if (lbl_chedo.ForeColor == Color.FromName("HOTPINK"))
            {
                lbl_chedo.ForeColor = Color.FromName("FUCHSIA");
            }
            else if (lbl_chedo.ForeColor == Color.FromName("FUCHSIA"))
            {
                lbl_chedo.ForeColor = Color.FromName("DEEPPINK");
            }
            else
            {
                lbl_chedo.ForeColor = Color.FromName("HOTPINK");
            }
        }
    }
}
