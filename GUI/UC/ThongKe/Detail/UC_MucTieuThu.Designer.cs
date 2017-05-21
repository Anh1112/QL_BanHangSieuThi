namespace GUI.UC.ThongKe.Detail
{
    partial class UC_MucTieuThu
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
            this.chartMucTieuThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMucTieuThu = new System.Windows.Forms.DataGridView();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.cbbHoaDon = new System.Windows.Forms.ComboBox();
            this.btnLoad = new GUI.Class.btnSimple();
            ((System.ComponentModel.ISupportInitialize)(this.chartMucTieuThu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucTieuThu)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMucTieuThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMucTieuThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMucTieuThu.Legends.Add(legend1);
            this.chartMucTieuThu.Location = new System.Drawing.Point(3, 53);
            this.chartMucTieuThu.Name = "chartMucTieuThu";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Mặt hàng";
            this.chartMucTieuThu.Series.Add(series1);
            this.chartMucTieuThu.Size = new System.Drawing.Size(360, 376);
            this.chartMucTieuThu.TabIndex = 0;
            this.chartMucTieuThu.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(369, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 47);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(147, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mức tiêu thụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMucTieuThu);
            this.panel1.Location = new System.Drawing.Point(369, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 376);
            this.panel1.TabIndex = 5;
            // 
            // dgvMucTieuThu
            // 
            this.dgvMucTieuThu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMucTieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMucTieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMucTieuThu.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMucTieuThu.Location = new System.Drawing.Point(0, 0);
            this.dgvMucTieuThu.Name = "dgvMucTieuThu";
            this.dgvMucTieuThu.Size = new System.Drawing.Size(390, 376);
            this.dgvMucTieuThu.TabIndex = 0;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.ForeColor = System.Drawing.Color.Red;
            this.lblHoaDon.Location = new System.Drawing.Point(18, 20);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(65, 13);
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Mã hóa đơn";
            // 
            // cbbHoaDon
            // 
            this.cbbHoaDon.FormattingEnabled = true;
            this.cbbHoaDon.Location = new System.Drawing.Point(103, 17);
            this.cbbHoaDon.Name = "cbbHoaDon";
            this.cbbHoaDon.Size = new System.Drawing.Size(121, 21);
            this.cbbHoaDon.TabIndex = 8;
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(262, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 21);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load chart";
            this.btnLoad.UseActived = false;
            this.btnLoad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLoad_MouseClick);
            // 
            // UC_MucTieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbbHoaDon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartMucTieuThu);
            this.Name = "UC_MucTieuThu";
            this.Size = new System.Drawing.Size(762, 475);
            this.Load += new System.EventHandler(this.UC_MucTieuThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMucTieuThu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMucTieuThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMucTieuThu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.ComboBox cbbHoaDon;
        private Class.btnSimple btnLoad;
        private System.Windows.Forms.DataGridView dgvMucTieuThu;
    }
}
