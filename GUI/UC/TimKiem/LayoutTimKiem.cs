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

namespace GUI.UC.TimKiem
{
    public partial class LayoutTimKiem : UserControl
    {
        public LayoutTimKiem()
        {
            InitializeComponent();
        }
        MatHang mh = new MatHang();

        void HienThi_MatHang()
        {
       
            DataTable dt = DTO.MatHang.Get_mathang();
            dgvTimKiem.DataSource = dt;
        }

        void TimKiemTen()
        {
            DataTable dt = new DataTable();
            dt = MatHang.findname(txtSearch.Text.Trim());
            dgvTimKiem.DataSource = dt;      
        }
        void TimKiemHang()
        {
            DataTable dt = new DataTable();
            dt = MatHang.findhang(txtSerchhang.Text.Trim());
            dgvTimKiem.DataSource = dt;
        }

        void TimKiemGia()
        {
            DataTable dt = new DataTable();
            dt = MatHang.findgia(txtSearchgia.Text.Trim());
            dgvTimKiem.DataSource = dt;
        }

        void TimKiemGiaNhap()
        {
            DataTable dt = new DataTable();
            dt = MatHang.findgianhap(txtSearchGiaNhap.Text.Trim());
            dgvTimKiem.DataSource = dt;
        }

        private void LayoutTimKiem_Load(object sender, EventArgs e)
        {
            HienThi_MatHang();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text=="nhập tên...")
            {
                HienThi_MatHang();
            }
            else
                 TimKiemTen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSerchhang_TextChanged(object sender, EventArgs e)
        {
            if(txtSerchhang.Text=="nhập hãng...")
            {
                HienThi_MatHang();
            }
            else
                TimKiemHang();
        }

        private void txtSearchgia_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchgia.Text=="nhập giá bán...")
            {
                HienThi_MatHang();
            }
            else
                TimKiemGia();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.ForeColor = Color.Gray;
                txtSearch.Text = "nhập tên...";
            }
        }

        private void txtSerchhang_MouseClick(object sender, MouseEventArgs e)
        {
            txtSerchhang.Text = "";
            txtSerchhang.ForeColor = Color.Black;
        }

        private void txtSerchhang_MouseLeave(object sender, EventArgs e)
        {
            if (txtSerchhang.Text == "")
            {
                txtSerchhang.ForeColor = Color.Gray;
                txtSerchhang.Text = "nhập hãng...";
            }
        }

        private void txtSearchgia_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearchgia.Text == "")
            {
                txtSearchgia.ForeColor = Color.Gray;
                txtSearchgia.Text = "nhập giá bán...";
            }
        }

        private void txtSearchgia_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchgia.Text = "";
            txtSearchgia.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchgia.Text == "nhập giá nhập...")
            {
                HienThi_MatHang();
            }
            else
                TimKiemGiaNhap();
        }

        private void txtSearchGiaNhap_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearchGiaNhap.Text == "")
            {
                txtSearchGiaNhap.ForeColor = Color.Gray;
                txtSearchGiaNhap.Text = "nhập giá nhập...";
                HienThi_MatHang();
            }
        }

        private void txtSearchGiaNhap_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchGiaNhap.Text = "";
            txtSearchGiaNhap.ForeColor = Color.Black;
        }
    }
}
