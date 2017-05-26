﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.QLBH
{
    public partial class LayoutQLBH : UserControl
    {
        public LayoutQLBH()
        {
            InitializeComponent();
        }

        private void btnHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            Control ctrl = this.Parent;
            while ((ctrl as Form) == null)
            {
                ctrl = ctrl.Parent;
            }
            ((FormMain)ctrl).IsMaximize = true;
            pnlXemHD.Visible = false;
            pnlThemHD.Visible = true;
        }

        private void btnChiTietHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            pnlThemHD.Visible = false;
            pnlXemHD.Visible = true;
        }

        private void load_mathang()
        {
            DataTable tb = DTO.MatHang.Get_mathang();

            tb.Columns.Remove(tb.Columns[7].ColumnName);
            tb.Columns.Remove(tb.Columns[4].ColumnName);
            tb.Columns.Remove(tb.Columns[2].ColumnName);

            tb.Columns.Add("chon", typeof(string)).SetOrdinal(0);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                tb.Rows[i].ItemArray[0] = "<<";
            }

            dgvHangHoa.DataSource = tb;

            ((DataTable)(dgvHangHoa.DataSource)).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{2}' OR [{1}] LIKE '%{2}%'", dgvHangHoa.Columns[1].Name, dgvHangHoa.Columns[2].Name, "!@#");

            dgvHangHoa.Columns[0].HeaderText = "";
            dgvHangHoa.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvHangHoa.Columns[0].Width = 50;
        }

        private void LayoutQLBH_Load(object sender, EventArgs e)
        {
            load_mathang();

            dtpTuNgay.Value = DateTime.Today;
            dtpDenNgay.Value = DateTime.Today;
        }

        private void pnlThemHD_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlThemHD.Visible)
            {
                load_mathang();

                txtMaHD.Text = DTO.HoaDon.Get_maHD();
                dtpNgayLap.Value = DateTime.Today;
                txtMaNV.Text = "0000000001";
            }
        }

        #region Them Hoa Don
        private void Search()
        {
            if (txtSearch.Text.Replace("0", "") != "")
            {
                ((DataTable)dgvHangHoa.DataSource).DefaultView.RowFilter = string.Format("([{0}] LIKE '%{2}' OR [{1}] LIKE '%{2}%')", dgvHangHoa.Columns[1].Name, dgvHangHoa.Columns[2].Name, txtSearch.Text);

                dgvHangHoa.Columns[0].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Green, SelectionForeColor = Color.Green, SelectionBackColor = Color.White, Alignment = DataGridViewContentAlignment.MiddleCenter };

                foreach (DataGridViewRow row in dgvHangHoa.Rows)
                {
                    row.Cells[0].Value = "<<";
                }
            }
            else
                ((DataTable)dgvHangHoa.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{2}' OR [{1}] LIKE '%{2}%'", dgvHangHoa.Columns[1].Name, dgvHangHoa.Columns[2].Name, "!@#");
            for (int i = 0; i < dgvHangHoa.Rows.Count; i++)
            {
                if (dgvHangHoa.Rows[i].Cells[5].Value == DBNull.Value || dgvHangHoa.Rows[i].Cells[5].Value == null || (double)dgvHangHoa.Rows[i].Cells[5].Value <= 0)
                {
                    dgvHangHoa.Rows[i].DefaultCellStyle = new DataGridViewCellStyle { ForeColor = Color.Crimson, SelectionBackColor = Color.Crimson };
                    dgvHangHoa.Rows[i].Cells[0].Style = new DataGridViewCellStyle { ForeColor = Color.Green, SelectionForeColor = Color.Green, SelectionBackColor = Color.White, Alignment = DataGridViewContentAlignment.MiddleCenter };
                }
            }
        }

        private void reset_SoLuong()
        {
            if (dgvHangHoa.Rows.Count > 0)
            {
                txtSoLuong.Text = (dgvHangHoa.CurrentRow.Cells[5].Value == DBNull.Value || dgvHangHoa.CurrentRow.Cells[5].Value == null || (double)dgvHangHoa.CurrentRow.Cells[5].Value <= 0) ? "0" : "1";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
            reset_SoLuong();
        }

        private void Update_SoluongDgvHH(string mahanghoa, double soluongthembot)
        {
            DataTable tb = (DataTable)dgvHangHoa.DataSource;
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                if (tb.Rows[i].ItemArray[1].ToString() == mahanghoa)
                {
                    double soluong = (double)tb.Rows[i].ItemArray[5] - soluongthembot;
                    tb.Rows[i].SetField(5, soluong);

                    dgvHangHoa.DataSource = tb;

                    for (int j = 0; j < dgvHangHoa.Rows.Count; j++)
                    {
                        dgvHangHoa.UpdateCellValue(5, j);
                        if (!((dgvHangHoa.CurrentRow.Cells[5].Value == DBNull.Value || dgvHangHoa.CurrentRow.Cells[5].Value == null || (double)dgvHangHoa.CurrentRow.Cells[5].Value <= 0)))
                            dgvHangHoa.Rows[j].DefaultCellStyle = dgvHangHoa.RowsDefaultCellStyle;
                    }
                    break;
                }
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;

            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                tong += (decimal)dgvCTHD.Rows[i].Cells[5].Value;

            labTongTien.Text = "Tổng tiền: " + tong + " VND";
        }

        private void ThemCTHD()
        {
            if (dgvHangHoa.Rows.Count > 0)
            {
                //1.ma, 2.ten, 3.donvi, 4.gia
                double soluong = double.Parse(txtSoLuong.Text);
                decimal dongia = (decimal)dgvHangHoa.CurrentRow.Cells[4].Value;
                decimal thanhtien = dongia * (decimal)soluong;

                Update_SoluongDgvHH(dgvHangHoa.CurrentRow.Cells[1].Value.ToString(), soluong);

                //thêm hàng đã tồn tại trong chi tiết hóa đơn
                for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                {
                    if (dgvCTHD.Rows[i].Cells[0].Value == dgvHangHoa.CurrentRow.Cells[1].Value)
                    {
                        dgvCTHD.Rows[i].Cells[3].Value = (double)dgvCTHD.Rows[i].Cells[3].Value + soluong;
                        dgvCTHD.Rows[i].Cells[5].Value = (decimal)((double)(dgvCTHD.Rows[i].Cells[3].Value)) * dongia;

                        TinhTongTien();

                        Search();
                        txtSearch.SelectAll();
                        reset_SoLuong();

                        Console.Beep(658, 125);
                        return;
                    }
                }

                //thêm hàng mới
                dgvCTHD.Rows.Add(dgvHangHoa.CurrentRow.Cells[1].Value, dgvHangHoa.CurrentRow.Cells[2].Value, dgvHangHoa.CurrentRow.Cells[3].Value, soluong, dongia, thanhtien, "X");
                dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Cells[4].Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "#.0000" };
                dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Cells[5].Style = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight, Format = "#.0000" };

                TinhTongTien();

                Search();
                txtSearch.SelectAll();
                txtSearch.Focus();
                reset_SoLuong();

                Console.Beep(658, 125);
            }
        }

        private void XoaCTHD()
        {
            Update_SoluongDgvHH(dgvCTHD.CurrentRow.Cells[0].Value.ToString(), -(double)dgvCTHD.CurrentRow.Cells[3].Value);
            dgvCTHD.Rows.Remove(dgvCTHD.CurrentRow);

            TinhTongTien();

            Search();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 13 && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 13 && dgvHangHoa.Rows.Count == 1 && double.Parse(txtSoLuong.Text) > 0)
            {
                e.Handled = true;

                ThemCTHD();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && dgvHangHoa.Rows.Count == 1 && double.Parse(txtSoLuong.Text) > 0)
            {
                e.Handled = true;

                ThemCTHD();
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                txtSoLuong.Text = "0";
                txtSoLuong.SelectAll();
                return;
            }
            if (dgvHangHoa.Rows.Count > 0 && !((dgvHangHoa.CurrentRow.Cells[5].Value == DBNull.Value || dgvHangHoa.CurrentRow.Cells[5].Value == null || (double)dgvHangHoa.CurrentRow.Cells[5].Value <= 0)))
            {
                if (double.Parse(txtSoLuong.Text) > (double)dgvHangHoa.CurrentRow.Cells[5].Value)
                {
                    txtSoLuong.Text = ((double)dgvHangHoa.CurrentRow.Cells[5].Value).ToString();
                    txtSoLuong.SelectAll();
                }
            }
            else
            {
                txtSoLuong.Text = "0";
                txtSoLuong.SelectAll();
            }
        }

        private void dgvHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (txtSoLuong.Text == "0") reset_SoLuong();

                if (e.ColumnIndex == 0)
                {
                    if (double.Parse(txtSoLuong.Text) > 0 && !((dgvHangHoa.CurrentRow.Cells[5].Value == DBNull.Value || dgvHangHoa.CurrentRow.Cells[5].Value == null || (double)dgvHangHoa.CurrentRow.Cells[5].Value <= 0)))
                        ThemCTHD();
                    else
                        System.Media.SystemSounds.Beep.Play();
                }

                reset_SoLuong();
            }
        }

        private void dgvCTHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.ColumnIndex == 6)
                {
                    XoaCTHD();
                }
            }
        }

        //Lưu vào CSDL
        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (txtMaKH.Text != "" && txtMaNV.Text != "" && dgvCTHD.Rows.Count > 0)
                {
                    DTO.HoaDon hoadon = new DTO.HoaDon()
                    {
                        Ma = txtMaHD.Text,
                        Khachhangma = txtMaKH.Text,
                        Nhanvienma = txtMaNV.Text,
                        Ngaylap = dtpNgayLap.Value,
                        Tongtien = decimal.Parse(labTongTien.Text.Split(' ')[2])
                    };
                    if(hoadon.Them() == 1)
                    {
                        for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                        {
                            DTO.ChiTietHoaDon chitiet = new DTO.ChiTietHoaDon()
                            {
                                Hoadonma = hoadon.Ma,
                                Mathangma = dgvCTHD.Rows[i].Cells[0].Value.ToString(),
                                Soluong = (double)dgvCTHD.Rows[i].Cells[3].Value,
                                Giaban = (decimal)dgvCTHD.Rows[i].Cells[4].Value
                            };
                            chitiet.Them();
                            DTO.MatHang.Update_SoLuongMatHang(chitiet.Mathangma);
                        }
                        txtMaKH.Text = "";
                        dgvCTHD.Rows.Clear();
                        txtSearch.Text = "";
                        txtMaHD.Text = DTO.HoaDon.Get_maHD();

                        MessageBox.Show("Đã thêm", "", MessageBoxButtons.OK);
                    }
                }
                else System.Media.SystemSounds.Beep.Play();
            }
        }
        #endregion
        

        #region Thêm Khách Hàng
        private void btnThemKH_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnlThemHD.Visible = false;
                pnlThemKH.Visible = true;
            }
        }

        private void pnlThemKH_VisibleChanged(object sender, EventArgs e)
        {
            if(pnlThemKH.Visible)
            {
                ClearInput_ThemKhachHang();
                _txtMaKH.Text = DTO.KhachHang.Get_MaKH();
            }
        }

        private void ClearInput_ThemKhachHang()
        {
            _txtMaKH.Text = "";
            _txtTenKH.Text = "";
            _txtSDT.Text = "";
            _cbxDiaChi.Text = "Hà Nội";
        }

        private void _btnThoat_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnlThemKH.Visible = false;
                pnlThemHD.Visible = true;
            }
        }

        private void _btnThemKH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DTO.KhachHang khachhang = new DTO.KhachHang()
                {
                    Ma = _txtMaKH.Text,
                    Ten = _txtTenKH.Text,
                    Sdt = _txtSDT.Text,
                    Diachi = _cbxDiaChi.Text
                };
                if(khachhang.them() == 1)
                {
                    pnlThemKH.Visible = false;
                    pnlThemHD.Visible = true;
                    txtMaKH.Text = khachhang.Ma;
                }
            }
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if(txtMaKH.Text.Length == 10)
            {
                DataTable tb = DTO.KhachHang.Get_KhachHang(txtMaKH.Text);
                if (tb.Rows.Count > 0)
                {
                    txtTenKH.Text = tb.Rows[0].ItemArray[1].ToString();
                    txtDiaChi.Text = tb.Rows[0].ItemArray[2].ToString();
                    labErrMaKH.Text = "";
                    labErrMaKH.ForeColor = Color.LimeGreen;
                    return;
                }
            }
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            labErrMaKH.Text = "";
            labErrMaKH.ForeColor = Color.Red;
        }
        #endregion



        //#region Xem Hoa Don
        private void load_HoaDon(DateTime tu_ngay, DateTime den_ngay)
        {
            DataTable tb_hoadon = DTO.HoaDon.Get_hoadon(tu_ngay, den_ngay);
            tb_hoadon.Columns.Add("Xoa", typeof(string));
            for (int i = 0; i < tb_hoadon.Rows.Count; i++)
            {
                tb_hoadon.Rows[i].SetField("Xoa", "xóa");
            }
            dgvXemHD.DataSource = tb_hoadon;
            dgvXemHD.Columns["Xoa"].HeaderText = "";
            dgvXemHD.Columns["Xoa"].DefaultCellStyle = new DataGridViewCellStyle() { ForeColor = Color.Crimson, SelectionForeColor = Color.Crimson, SelectionBackColor = Color.White, Alignment = DataGridViewContentAlignment.MiddleCenter };
            dgvXemHD.Columns["Xoa"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvXemHD.Columns["Xoa"].Width = 50;
        }

        private void TinhTongTienHoaDon()
        {
            decimal tong = 0;
            for (int i = 0; i < dgvXemHD.Rows.Count; i++)
            {
                tong += (decimal)dgvXemHD.Rows[i].Cells[3].Value;
            }
            labTongTienHoaDon.Text = "Tổng tiền hóa đơn: " + tong + " VND";
        }

        private void pnlXemHD_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlXemHD.Visible)
            {
                if (btnSimple1.BackColor == btnSimple1.ColorMouseDown)
                {
                    load_HoaDon(DateTime.Today, DateTime.Today);
                    TinhTongTienHoaDon();
                }
                else
                {
                    load_HoaDon(dtpTuNgay.Value, dtpDenNgay.Value);
                    labTongTienHoaDon.Text = "Tổng tiền hóa đơn: ";
                }
            }
        }

        private void DateTimeSearch_ValueChanged(object sender, EventArgs e)
        {
            if (pnlXemHD.Visible)
            {
                load_HoaDon(dtpTuNgay.Value, dtpDenNgay.Value);
                btnSimple1.Actived = false;
                labTongTienHoaDon.Text = "Tổng tiền hóa đơn: ";
            }
        }

        private void btnSimple1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                load_HoaDon(DateTime.Today, DateTime.Today);
                TinhTongTienHoaDon();
            }
        }

        private void dgvXemHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Xác nhận xóa?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DataTable tb_chitietHD = DTO.ChiTietHoaDon.Get_chitiethoadon(dgvXemHD.CurrentRow.Cells[0].Value.ToString());
                    DTO.HoaDon.Xoa(dgvXemHD.CurrentRow.Cells[0].Value.ToString());
                    for (int i = 0; i < tb_chitietHD.Rows.Count; i++)
                    {
                        DTO.MatHang.Update_SoLuongMatHang(tb_chitietHD.Rows[i].ItemArray[0].ToString());
                    }
                    if (btnSimple1.BackColor == btnSimple1.ColorMouseDown)
                        load_HoaDon(DateTime.Today, DateTime.Today);
                    else
                        load_HoaDon(dtpTuNgay.Value, dtpDenNgay.Value);
                }
            }
        }
    }
}
