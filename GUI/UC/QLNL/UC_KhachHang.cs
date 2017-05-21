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
using DAL;

namespace GUI.UC.QLNL
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        KhachHang kh = new KhachHang();
        bool ThemMoi;

        public KhachHang Kh { get => kh; set => kh = value; }

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        void HienThi()
        {
            DataTable dt = Kh.get_khachhang();
            dgvKhachHang.DataSource = dt;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            ThemMoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            try
            {
                Kh.Ma = txtMa.Text;
                Kh.xoa(Kh.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    Kh.Ma = txtMa.Text;
                    Kh.Ten = txtTen.Text;
                    Kh.Diachi = txtDiaChi.Text;
                    Kh.Sdt = txtSDT.Text;
                    Kh.them();
                    MessageBox.Show("Đã thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            else
            {
                try
                {
                    Kh.Ma = txtMa.Text;
                    Kh.Ten = txtTen.Text;
                    Kh.Diachi = txtDiaChi.Text;
                    Kh.Sdt = txtSDT.Text;
                    Kh.sua();
                    MessageBox.Show("Đã sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Lỗi!");
                    return;
                }
            }
            SetNull();
            KhoaDieuKhien();
            HienThi();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvKhachHang.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvKhachHang.Rows[Row_Index].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[Row_Index].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }
    }
}
