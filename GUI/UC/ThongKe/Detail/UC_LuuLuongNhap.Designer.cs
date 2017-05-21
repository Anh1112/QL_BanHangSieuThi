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
            this.ChartHangTrongKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMaNhapKho = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblNhapKho = new System.Windows.Forms.Label();
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
            chartArea1.Name = "ChartArea1";
            this.ChartHangTrongKho.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartHangTrongKho.Legends.Add(legend1);
            this.ChartHangTrongKho.Location = new System.Drawing.Point(3, 51);
            this.ChartHangTrongKho.Name = "ChartHangTrongKho";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Mặt hàng";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChartHangTrongKho.Series.Add(series1);
            this.ChartHangTrongKho.Size = new System.Drawing.Size(354, 369);
            this.ChartHangTrongKho.TabIndex = 1;
            this.ChartHangTrongKho.Text = "Hàng trong kho";
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
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lưu lượng nhập hàng";
            // 
            // cbbMaNhapKho
            // 
            this.cbbMaNhapKho.FormattingEnabled = true;
            this.cbbMaNhapKho.Location = new System.Drawing.Point(102, 17);
            this.cbbMaNhapKho.Name = "cbbMaNhapKho";
            this.cbbMaNhapKho.Size = new System.Drawing.Size(121, 21);
            this.cbbMaNhapKho.TabIndex = 5;
            // 
            // lblNhapKho
            // 
            this.lblNhapKho.AutoSize = true;
            this.lblNhapKho.ForeColor = System.Drawing.Color.Red;
            this.lblNhapKho.Location = new System.Drawing.Point(19, 22);
            this.lblNhapKho.Name = "lblNhapKho";
            this.lblNhapKho.Size = new System.Drawing.Size(70, 13);
            this.lblNhapKho.TabIndex = 6;
            this.lblNhapKho.Text = "Mã nhập kho";
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(256, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 21);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load chart";
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
            this.dgvLuuLuongNhapHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLuuLuongNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuuLuongNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuuLuongNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvLuuLuongNhapHang.Name = "dgvLuuLuongNhapHang";
            this.dgvLuuLuongNhapHang.Size = new System.Drawing.Size(396, 369);
            this.dgvLuuLuongNhapHang.TabIndex = 0;
            // 
            // UC_LuuLuongNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblNhapKho);
            this.Controls.Add(this.cbbMaNhapKho);
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
        private System.Windows.Forms.ComboBox cbbMaNhapKho;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblNhapKho;
        private Class.btnSimple btnLoad;
    }
}
