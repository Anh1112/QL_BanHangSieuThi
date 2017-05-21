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

namespace GUI.UC.QLNH
{
    public partial class LayoutQLNH : UserControl
    {
        public LayoutQLNH()
        {
            InitializeComponent();
        }

        private void LayoutQLNH_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DATA.get_nhapkho();
            
           
            dgv_nhapkho.DataSource = dt;
            dgv_nhapkho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_nhapkho.Columns[0].HeaderText = "Mã";
            dgv_nhapkho.Columns[0].Width = 65;
            dgv_nhapkho.Columns[1].HeaderText = "Ngày Nhập";
            dgv_nhapkho.Columns[1].Width = 100;
            dgv_nhapkho.Columns[2].HeaderText = "Tổng Tiền";
            dgv_nhapkho.Columns[2].Width = 120;
            dgv_nhapkho.Columns[3].HeaderText = "Nhân viên";
            dgv_nhapkho.Columns[3].Width = 85;
            for(int i = 0;i<4;i++)
            {
                dgv_nhapkho.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void dgv_nhapkho_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string ma;
            DateTime ngaynhap;
            decimal tongtien;
            string nhanvienma;
            for(int i = 0; i <3;i++)
            {
                if (dgv_nhapkho.Rows[e.RowIndex].Cells[i].Value.ToString()=="" || dgv_nhapkho.Rows[e.RowIndex].Cells[i].Value.ToString() == null)
                {
                    MessageBox.Show("Không được để trống!");
                    return;
                }
            }
            ma = dgv_nhapkho.Rows[e.RowIndex].Cells[0].Value.ToString();
            ngaynhap = DateTime.Parse(dgv_nhapkho.Rows[e.RowIndex].Cells[1].Value.ToString());
            tongtien = decimal.Parse(dgv_nhapkho.Rows[e.RowIndex].Cells[2].Value.ToString());
            nhanvienma = dgv_nhapkho.Rows[e.RowIndex].Cells[3].Value.ToString();
            DATA.sua_nhapkho(ma, ngaynhap, tongtien, nhanvienma);
        }

        private void dgv_nhapkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          string ma=  dgv_nhapkho.CurrentRow.Cells[0].Value.ToString();
            dgv_CTnhapkho.DataSource = DATA.get_chitietnhapkho(ma);
            dgv_CTnhapkho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_CTnhapkho.Columns[0].Visible=false;
            dgv_CTnhapkho.Columns[1].HeaderText = "Ngày Nhập";
            dgv_CTnhapkho.Columns[1].Width = 100;
            dgv_CTnhapkho.Columns[2].HeaderText = "Tổng Tiền";
            dgv_CTnhapkho.Columns[2].Width = 120;
            dgv_CTnhapkho.Columns[3].HeaderText = "Nhân viên";
            dgv_CTnhapkho.Columns[3].Width = 85;
        }
    }
}
