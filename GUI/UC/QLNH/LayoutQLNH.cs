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
        private int rowindex;
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
            btn_newCTnk.Visible = false;
           adddlnk();
        }

        private void _saveclick()
        {

            adddlnk();
        }
        private void addDLCTNK()
        {
            string[] name = { "Mã mặt hàng", "Tên mặt hàng", "Ngày nhập", "Đơn vị", "Số lượng", "Giá Bán", "Tổng tiền" };
            string ma = dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
            dgv_CTnhapkho.DataSource = DATA.get_chitietnhapkho(ma);
            dgv_CTnhapkho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CTnhapkho.Columns[1].Visible = false;
            dgv_CTnhapkho.Columns[0].Width = 130;
            dgv_CTnhapkho.Columns[2].Width = 130;
            dgv_CTnhapkho.Columns[3].Width = 100;
            dgv_CTnhapkho.Columns[4].Width = 95;
            dgv_CTnhapkho.Columns[5].Width = 120;
            dgv_CTnhapkho.Columns[6].Width = 130;
            for (int i = 0; i < dgv_CTnhapkho.Columns.Count; i++)
            {
                dgv_CTnhapkho.Columns[i].HeaderText = name[i];
                dgv_CTnhapkho.Columns[i].ReadOnly = true;
            }
        }
        private void dgv_nhapkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_nhapkho.CurrentRow.Cells[0].Value.ToString()!="")
            {
                btn_newCTnk.Visible = true;
                addDLCTNK();
            }
            rowindex = e.RowIndex;
        }

        private void btnNhapKho_MouseClick(object sender, MouseEventArgs e)
        {
            fulltableCT();
        }

        private void btnChiTietNhapKho_MouseClick(object sender, MouseEventArgs e)
        {
            fulltableCT();
        }
        private NhapKho adddl()
        {
            NhapKho nk = new NhapKho();
            nk.Ma = dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
            nk.NgayNhap = DateTime.Parse(dgv_nhapkho.CurrentRow.Cells[1].Value.ToString());
            if(dgv_nhapkho.CurrentRow.Cells[2].Value.ToString()!="")
            nk.Tongtien = decimal.Parse(dgv_nhapkho.CurrentRow.Cells[2].Value.ToString());
            if (dgv_nhapkho.CurrentRow.Cells[3].Value.ToString() != "")
            {
                nk.NhanVienMa = dgv_nhapkho.CurrentRow.Cells[3].Value.ToString();
            }
            return nk;
        }
        private void dgv_nhapkho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                if (dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value != null && dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
                {
                    NhapKho nk = new NhapKho();
                    nk = adddl();
                    changenk cnk = new changenk(nk);
                    cnk.change = true;
                    cnk.ShowDialog();
                }
                rowindex = e.RowIndex;
            }

       
        }
        private void btn_newnk_MouseClick(object sender, MouseEventArgs e)
        {
            changenk cnk = new changenk();
            cnk.change = false;
            cnk.saveclick += _saveclick;
            btn_newnk.Actived = false;
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
                    adddlnk();
                }
            }
        }

        private void dgv_CTnhapkho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_CTnhapkho.CurrentRow.Cells[0].Value.ToString()!=null)
            {
                ChiTietNhapKho ct = new ChiTietNhapKho();
                ct.MatHangMa = dgv_CTnhapkho.CurrentRow.Cells[0].Value.ToString();
                ct.NhapKhoMa = dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
                ct.soLuong = int.Parse(dgv_CTnhapkho.CurrentRow.Cells[4].Value.ToString());
                ct.Giaban = decimal.Parse(dgv_CTnhapkho.CurrentRow.Cells[5].Value.ToString());
                ChangeCTnk ctnk = new ChangeCTnk(ct);
                ctnk.change = true;
                ctnk.ShowDialog();
                addDLCTNK();
                adddlnk();
                //ct.MatHangMa=
            }
        }

        private void btn_newCTnk_MouseClick(object sender, MouseEventArgs e)
        {
            if(dgv_nhapkho.CurrentRow.ToString()!="")
            {
                ChangeCTnk ct = new ChangeCTnk(dgv_nhapkho.CurrentRow.Cells[0].Value.ToString());
                ct.saveCTclick += _saveCTclick;
                ct.change = false;
                ct.ShowDialog();
                btn_newCTnk.Actived = false;
            }
         
        }

        private void _saveCTclick()
        {
            addDLCTNK();
        }

        private void dgv_CTnhapkho_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgv_CTnhapkho.CurrentRow.Cells[0].Value.ToString() != "")
            {


                if (e.KeyCode == Keys.Delete)
                {
                    var result = MessageBox.Show("Bạn thật sự muốn xóa", "",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DATA.xoa_chitietnhapkho( dgv_CTnhapkho.CurrentRow.Cells[0].Value.ToString(),dgv_nhapkho.CurrentRow.Cells[0].Value.ToString());
                        addDLCTNK();
                        adddlnk();
                    }
                }
            }
        }
    }
}
