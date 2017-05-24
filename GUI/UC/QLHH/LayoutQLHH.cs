using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace GUI.UC.QLHH
{
    public partial class LayoutQLHH : UserControl
    {
        public LayoutQLHH()
        {
            InitializeComponent();
        }
        MatHang mh = new MatHang();
        QuayHang qh = new QuayHang();
        bool ThemMoi;
        void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtHangSX.Enabled = false;
            txtDonViTinh.Enabled = false; 
            txtGiaNhap.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSLkho.Enabled = false;
            cboQuayMa.Enabled = false;
            txtmaquay.Enabled = false;
            txtTenquay.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = false;
            btnThemqh.Enabled = true;
            btnSuaqh.Enabled = true;
            btnCapNhatqh.Enabled = false;
        }

        void MoDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtHangSX.Enabled = true;
            txtDonViTinh.Enabled = true;
            txtGiaNhap.Enabled =true;
            txtGiaBan.Enabled = true;
            txtSLkho.Enabled = true;
            cboQuayMa.Enabled = true;
            txtmaquay.Enabled = false;
            txtTenquay.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = true;
            btnThemqh.Enabled = false;
            btnSuaqh.Enabled = false;
            btnCapNhatqh.Enabled = true;
        }

        void SetNull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtHangSX.Text = "";
            txtDonViTinh.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            txtSLkho.Text = "";
            cboQuayMa.Text = "";
            txtmaquay.Text = "";
            txtTenquay.Text = "";
        }

        void HienThi_cboQuayMa()
        {

            DataTable dt = new DataTable();
            dt = DBConnect.GetData(@"Select ma from quayhang");
            cboQuayMa.DataSource = dt;
            cboQuayMa.DisplayMember = "ma";
            cboQuayMa.ValueMember = "ma";
        }
        void HienThi_MatHang()
        {
            // DataTable dt = mh.Get_mathang();
            DataTable dt = DTO.MatHang.Get_mathang();
            dgvMatHang.DataSource = dt;
        }

        void HienThi_QuayHang()
        {
            DataTable dt = qh.get_quayhang();
            dgvQuayHang.DataSource = dt;
        }
        private void LayoutQLHH_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi_MatHang();
            HienThi_QuayHang();
            HienThi_cboQuayMa();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void btnSuaqh_Click(object sender, EventArgs e)
        {

            MoDieuKhien();
            txtmaquay.Enabled = false;
            ThemMoi = false;
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
                mh.Ma = txtMa.Text;
                mh.Xoa(mh.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi_MatHang();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
               
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            

            if (ThemMoi == true)
            {
                try
                {
                    decimal a,b;
                    decimal.TryParse(txtGiaBan.Text, out a);
                    decimal.TryParse(txtGiaNhap.Text, out b);
                    float c;
                    float.TryParse(txtSLkho.Text, out c);
                    mh.Ma = txtMa.Text;
                    mh.Ten = txtTen.Text;
                    mh.Hangsanxuat = txtHangSX.Text;
                    mh.Donvitinh = txtDonViTinh.Text;
                    mh.Giaban = a;
                    mh.Gianhap = b;
                    mh.Soluongtrongkho = c;
                    mh.Quayma = cboQuayMa.Text;
                    DATA.them_mathang(mh.Ma, mh.Ten, mh.Hangsanxuat, mh.Donvitinh, mh.Gianhap, mh.Giaban, mh.Soluongtrongkho, mh.Quayma);
                    //    mh.Them();
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
                    decimal a, b;
                    decimal.TryParse(txtGiaBan.Text, out a);
                    decimal.TryParse(txtGiaNhap.Text, out b);
                    float c;
                    float.TryParse(txtSLkho.Text, out c);
                    mh.Ma = txtMa.Text;
                    mh.Ten = txtTen.Text;
                    mh.Hangsanxuat = txtHangSX.Text;
                    mh.Donvitinh = txtDonViTinh.Text;
                    mh.Giaban = a;
                    mh.Gianhap = b;
                    mh.Soluongtrongkho = c;
                    mh.Quayma = cboQuayMa.Text;
                    // DATA.sua_mathang(mh.Ma, mh.Ten, mh.Hangsanxuat, mh.Donvitinh, mh.Gianhap, mh.Giaban, mh.Soluongtrongkho, mh.Quayma);
                    mh.Sua();
                    MessageBox.Show("Đã sửa thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi!"+ ex.ToString());
                    return;
                }
            }
            SetNull();
            KhoaDieuKhien();
            HienThi_MatHang();
        }

        private void btnThemqh_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            ThemMoi = true;
        }

        private void btnXoaqh_Click(object sender, EventArgs e)
        {
            try
            {
                qh.Ma = txtmaquay.Text;
                qh.xoa_quayhang(qh.Ma);
                MessageBox.Show("Đã xóa thành công!");
                KhoaDieuKhien();
                SetNull();
                HienThi_QuayHang();
            }
            catch
            {
                MessageBox.Show("Lỗi không thể xóa!");
            }
        }

        private void btnCapNhatqh_Click(object sender, EventArgs e)
        {
            if (ThemMoi == true)
            {
                try
                {
                    qh.Ma = txtmaquay.Text;
                    qh.Ten = txtTenquay.Text;
                    qh.them_quayhang();
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
                    qh.Ma = txtmaquay.Text;
                    qh.Ten = txtTenquay.Text;
                    qh.sua_quayhang();
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
            HienThi_QuayHang();
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtMa.Text = dgvMatHang.Rows[Row_Index].Cells[0].Value.ToString();
                txtTen.Text = dgvMatHang.Rows[Row_Index].Cells[1].Value.ToString();
                txtHangSX.Text = dgvMatHang.Rows[Row_Index].Cells[2].Value.ToString();
                txtDonViTinh.Text = dgvMatHang.Rows[Row_Index].Cells[3].Value.ToString();
                txtGiaNhap.Text = dgvMatHang.Rows[Row_Index].Cells[4].Value.ToString();
                txtGiaBan.Text = dgvMatHang.Rows[Row_Index].Cells[5].Value.ToString();             
                txtSLkho.Text = dgvMatHang.Rows[Row_Index].Cells[6].Value.ToString();
                cboQuayMa.Text = dgvMatHang.Rows[Row_Index].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void dgvQuayHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try
            {
                int Row_Index = e.RowIndex;
                txtmaquay.Text = dgvQuayHang.Rows[Row_Index].Cells[0].Value.ToString();
                txtTenquay.Text = dgvQuayHang.Rows[Row_Index].Cells[1].Value.ToString();               
            }
            catch
            {

            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
          //  txtMa.Text = ""+DateTime.Now.Day.ToString().Trim()+"" + DateTime.Now.Hour.ToString().Trim() + ""+DateTime.Now.Minute.ToString().Trim()+""+DateTime.Now.Millisecond.ToString().Trim()+"";
        }

        private void txtTenquay_TextChanged(object sender, EventArgs e)
        {
          //  txtmaquay.Text = "" + DateTime.Now.Day.ToString().Trim() + "" + DateTime.Now.Hour.ToString().Trim() + "" + DateTime.Now.Minute.ToString().Trim() + "" + DateTime.Now.Millisecond.ToString().Trim() + "";
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetNull();
                    if (dgvMatHang.DataSource != null)
                    {
                        List<string> list = ((DataTable)dgvMatHang.DataSource).AsEnumerable().Select(x => x.Field<string>(dgvMatHang.Columns[0].Name)).ToList();
                        if (list.Count > 0) txtMa.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtMa.Text = "0000000001";
                    }
                    else txtMa.Text = "0000000001";
                }
            }
        }

        private void btnThemqh_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    SetNull();
                    if (dgvQuayHang.DataSource != null)
                    {
                        List<string> list = ((DataTable)dgvQuayHang.DataSource).AsEnumerable().Select(x => x.Field<string>(dgvQuayHang.Columns[0].Name)).ToList();
                        if (list.Count > 0) txtmaquay.Text = string.Format("{0:d10}", int.Parse(list.Max()) + 1);
                        else txtmaquay.Text = "0000000001";
                    }
                    else txtmaquay.Text = "0000000001";
                }
            }
        }
    }
}
