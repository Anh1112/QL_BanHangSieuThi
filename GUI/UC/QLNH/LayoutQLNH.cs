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
namespace GUI.UC.QLNH
{
    public partial class LayoutQLNH : UserControl
    {
        private bool fullCT = false;
        private string lasttext;
        private void fulltableCT()
        {
            
            if(fullCT==false)
            {
                pnl_nhapkho.Visible = false;
                pnl_CTnhapkho.Dock = DockStyle.Fill;
                fullCT = true;
            }
            else
            {
                pnl_nhapkho.Visible = true;
                pnl_CTnhapkho.Dock = DockStyle.None;
                fullCT = false;
            }
            btnNhapKho.Actived = false;
            btnChiTietNhapKho.Actived = false;
        }
        public LayoutQLNH()
        {
            InitializeComponent();
        }
        private void adddlnk()
        {
            DataTable dt = new DataTable();
            dt = DATA.get_nhapkho();

            if (dt != null)
            {
                dgv_nhapkho.DataSource = dt;
                dgv_nhapkho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                for (int i = 0; i < dgv_nhapkho.Columns.Count; i++)
                {
                    dgv_nhapkho.Columns[i].ReadOnly = true;
                }
                dgv_nhapkho.Columns[0].HeaderText = "Mã";
                dgv_nhapkho.Columns[0].Width = 65;
                dgv_nhapkho.Columns[1].HeaderText = "Ngày Nhập";
                dgv_nhapkho.Columns[1].Width = 100;
                dgv_nhapkho.Columns[2].HeaderText = "Tổng Tiền";
                dgv_nhapkho.Columns[2].Width = 120;
                dgv_nhapkho.Columns[3].HeaderText = "Nhân viên";
                dgv_nhapkho.Columns[3].Width = 85;
                for (int i = 0; i < 4; i++)
                {
                    dgv_nhapkho.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
        private void LayoutQLNH_Load(object sender, EventArgs e)
        {
            adddlnk();
        }

        private void _saveclick()
        {

            adddlnk();
        }

        private void dgv_nhapkho_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string ma;
            DateTime ngaynhap;
            decimal tongtien;
            string nhanvienma;
            
                if (dgv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()=="" || dgv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == null)
                {
                    MessageBox.Show("Không được để trống "+ dgv_nhapkho.Columns[e.ColumnIndex].HeaderText);
                    dgv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = lasttext;
                    return;
                }
            
            ma = dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value.ToString();
            ngaynhap = DateTime.Parse( dgv_nhapkho.Rows[e.RowIndex].Cells[1].Value.ToString());
            tongtien = decimal.Parse(dgv_nhapkho.Rows[e.RowIndex].Cells[2].Value.ToString());
            nhanvienma = dgv_nhapkho.Rows[e.RowIndex].Cells[3].Value.ToString();
            DATA.sua_nhapkho(ma, ngaynhap, tongtien, nhanvienma);
        }

        private void dgv_nhapkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          string ma=  dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
            dgv_CTnhapkho.DataSource = DATA.get_chitietnhapkho(ma);
            dgv_CTnhapkho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CTnhapkho.Columns[1].Visible=false;
            dgv_CTnhapkho.Columns[0].Width = 130;
            dgv_CTnhapkho.Columns[2].Width = 130;
            dgv_CTnhapkho.Columns[3].Width = 100;
            dgv_CTnhapkho.Columns[4].Width = 95;
            dgv_CTnhapkho.Columns[5].Width = 120;
            dgv_CTnhapkho.Columns[6].Width = 130;
            for (int i = 0; i < dgv_CTnhapkho.Columns.Count; i++)
            {
                dgv_CTnhapkho.Columns[i].ReadOnly = true;
            }
        }

        private void btnNhapKho_MouseClick(object sender, MouseEventArgs e)
        {
            fulltableCT();
        }

        private void btnChiTietNhapKho_MouseClick(object sender, MouseEventArgs e)
        {
            fulltableCT();
        }

        private void dgv_nhapkho_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                lasttext = dgv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
        private NhapKho adddl()
        {
            NhapKho nk = new NhapKho();
            nk.Ma = dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
            nk.NgayNhap = DateTime.Parse(dgv_nhapkho.CurrentRow.Cells[1].Value.ToString());
            nk.Tongtien = decimal.Parse(dgv_nhapkho.CurrentRow.Cells[2].Value.ToString());
            if (dgv_nhapkho.CurrentRow.Cells[3].Value.ToString() != "")
            {
                nk.NhanVienMa = dgv_nhapkho.CurrentRow.Cells[3].Value.ToString();
            }
            return nk;
        }
        private void dgv_nhapkho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value!=null && dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value.ToString() !="" )
            {
                NhapKho nk = new NhapKho();
               nk= adddl();
            changenk cnk = new changenk(nk);
                cnk.change = true;
            cnk.ShowDialog();
            }
       
        }
        private void btn_newnk_MouseClick(object sender, MouseEventArgs e)
        {
            changenk cnk = new changenk();
            cnk.change = false;
            cnk.saveclick += _saveclick;
            cnk.ShowDialog();
        }

        private void dgv_nhapkho_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                var result = MessageBox.Show("Bạn thật sự muốn xóa", "",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                if(result== DialogResult.Yes)
                {
                    DATA.xoa_nhapkho(dgv_nhapkho.CurrentRow.Cells[0].Value.ToString());
                }
                adddlnk();
            }
        }

        private void btnNhapKho_MouseClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
