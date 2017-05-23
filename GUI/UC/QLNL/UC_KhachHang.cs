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

     // public KhachHang Kh { get => kh; set => kh = value; }
     public KhachHang  Kh
        {
            get { return kh; }
            set { kh = value; }
        }

        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cboDiaChi.Enabled = false;
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
            cboDiaChi.Enabled = true;
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
            cboDiaChi.Text = "";
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
                    kh.Ma = txtMa.Text;
                    kh.Ten = txtTen.Text;
                    kh.Diachi = cboDiaChi.Text;
                    kh.Sdt = txtSDT.Text;
                    kh.them();
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
                    kh.Ma = txtMa.Text;
                    kh.Ten = txtTen.Text;
                    kh.Diachi = cboDiaChi.Text;
                    kh.Sdt = txtSDT.Text;
                    kh.sua();
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
                cboDiaChi.Text = dgvKhachHang.Rows[Row_Index].Cells[2].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[Row_Index].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }
        void TimKiem()
        {
            DataTable dt = new DataTable();
            dt = DAL.DBConnect.GetData(@"select ma as [Mã Khách Hàng], ten as [Tên Nhân Viên],  diachi as [Địa Chỉ], sdt as [Số Điện Thoại]from khachhang where ten like '%" + txtSearch.Text.Trim() + "%' or ma like '%" + txtSearch.Text.Trim() + "%'");
            dgvKhachHang.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
