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

namespace GUI.UC.QLNL
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cboDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            cboChucVu.Enabled = false;
            txtLuong.Enabled = false;
            cboMaQuay.Enabled = false;
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
            cboChucVu.Enabled = true;
            txtLuong.Enabled = true;
            cboMaQuay.Enabled = true;
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
            txtLuong.Text = "";
            cboChucVu.Text = "";
            cboMaQuay.Text = "";
        }

        void HienThi()
        {
            DataTable dt = nv.get_nhanvien();
            dgvNhanVien.DataSource = dt;
        }

        void HienThi_cboQuayMa()
        {

            DataTable dt = new DataTable();
            dt = QuayHang.get_maquayhang();
            cboMaQuay.DataSource = dt;
            cboMaQuay.DisplayMember = "ma";
            cboMaQuay.ValueMember = "ma";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
            HienThi_cboQuayMa();
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
                nv.Ma = txtMa.Text;
                nv.xoa_nhanvien(nv.Ma);
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
                    decimal a;
                    DateTime b;
                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    nv.Diachi = cboDiaChi.Text;
                    nv.Sdt = txtSDT.Text;
                    nv.Chucvu = cboChucVu.Text;
                    decimal.TryParse(txtLuong.Text, out a);
                    nv.Luong = a;
                    DateTime.TryParse(dtpNgaySinh.Text, out b);
                    nv.Ngaysinh = b;
                    nv.Quayma = cboMaQuay.Text;

                    nv.them_nhanvien();
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
                    decimal a;
                    DateTime b;
                    nv.Ma = txtMa.Text;
                    nv.Ten = txtTen.Text;
                    nv.Diachi = cboDiaChi.Text;
                    nv.Sdt = txtSDT.Text;
                    nv.Chucvu = cboChucVu.Text;
                    decimal.TryParse(txtLuong.Text, out a);
                    nv.Luong = a;
                    DateTime.TryParse(dtpNgaySinh.Text, out b);
                    nv.Ngaysinh = b;
                    nv.Quayma = cboMaQuay.Text;
                    nv.sua_nhanvien();
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvNhanVien.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvNhanVien.Rows[Row_Index].Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgvNhanVien.Rows[Row_Index].Cells[2].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[Row_Index].Cells[3].Value.ToString();
                cboDiaChi.Text = dgvNhanVien.Rows[Row_Index].Cells[4].Value.ToString();
                cboChucVu.Text = dgvNhanVien.Rows[Row_Index].Cells[5].Value.ToString();
                txtLuong.Text = dgvNhanVien.Rows[Row_Index].Cells[6].Value.ToString();
                cboMaQuay.Text = dgvNhanVien.Rows[Row_Index].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }
        void TimKiem()
        {
            DataTable dt = new DataTable();
            dt = DAL.DBConnect.GetData(@"select * from nhanvien where ten like '%" + txtSearch.Text.Trim() + "%' or ma like '%" + txtSearch.Text.Trim() + "%'");
            dgvNhanVien.DataSource = dt;
        }

        private void labSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtMa.Text = "" + DateTime.Now.Day.ToString().Trim() + "" + DateTime.Now.Hour.ToString().Trim() + "" + DateTime.Now.Minute.ToString().Trim() + "" + DateTime.Now.Millisecond.ToString().Trim() + "";

        }
    }
}
