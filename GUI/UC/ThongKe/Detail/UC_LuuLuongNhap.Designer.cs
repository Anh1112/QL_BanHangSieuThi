namespace GUI.UC.ThongKe.Detail
{
    partial class UC_LuuLuongNhap
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartHangTrongKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new GUI.Class.btnSimple();
            this.panel_Simple1 = new GUI.Class.Panel_Simple();
            this.dgvLuuLuongNhapHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHangTrongKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_Simple1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuuLuongNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartHangTrongKho
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.ChartHangTrongKho.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartHangTrongKho.Legends.Add(legend1);
            this.ChartHangTrongKho.Location = new System.Drawing.Point(3, 66);
            this.ChartHangTrongKho.Name = "ChartHangTrongKho";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Mặt hàng";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChartHangTrongKho.Series.Add(series1);
            this.ChartHangTrongKho.Size = new System.Drawing.Size(354, 354);
            this.ChartHangTrongKho.TabIndex = 1;
            this.ChartHangTrongKho.Text = "Hàng trong kho";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "Title1";
            title1.Text = "Lưu lượng nhập hàng";
            this.ChartHangTrongKho.Titles.Add(title1);
            this.ChartHangTrongKho.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(366, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 42);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(110, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lưu lượng nhập hàng";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(79, 14);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 8;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(79, 40);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 9;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(27, 20);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(46, 13);
            this.lblTuNgay.TabIndex = 10;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến ngày";
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(285, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(76, 24);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = " ▼  Load ";
            this.btnLoad.UseActived = false;
            this.btnLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLoad_MouseClick);
            // 
            // panel_Simple1
            // 
            this.panel_Simple1.BotRightColor = System.Drawing.SystemColors.Control;
            this.panel_Simple1.BottomLeftColor = System.Drawing.SystemColors.Control;
            this.panel_Simple1.Controls.Add(this.dgvLuuLuongNhapHang);
            this.panel_Simple1.Location = new System.Drawing.Point(366, 51);
            this.panel_Simple1.Name = "panel_Simple1";
            this.panel_Simple1.Size = new System.Drawing.Size(396, 369);
            this.panel_Simple1.TabIndex = 4;
            this.panel_Simple1.TopLeftColor = System.Drawing.SystemColors.Control;
            this.panel_Simple1.TopRightColor = System.Drawing.SystemColors.Control;
            // 
            // dgvLuuLuongNhapHang
            // 
            this.dgvLuuLuongNhapHang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLuuLuongNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuuLuongNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuuLuongNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvLuuLuongNhapHang.Name = "dgvLuuLuongNhapHang";
            this.dgvLuuLuongNhapHang.Size = new System.Drawing.Size(396, 369);
            this.dgvLuuLuongNhapHang.TabIndex = 0;
            this.dgvLuuLuongNhapHang.Visible = false;
            // 
            // UC_LuuLuongNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTuNgay);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel_Simple1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ChartHangTrongKho);
            this.Name = "UC_LuuLuongNhap";
            this.Size = new System.Drawing.Size(762, 475);
            this.Load += new System.EventHandler(this.UC_LuuLuongNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartHangTrongKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_Simple1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuuLuongNhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartHangTrongKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Class.Panel_Simple panel_Simple1;
        private System.Windows.Forms.DataGridView dgvLuuLuongNhapHang;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Class.btnSimple btnLoad;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label label2;
    }
}
