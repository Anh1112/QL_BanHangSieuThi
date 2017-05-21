namespace GUI.UC.ThongKe.Detail
{
    partial class UC_HangTrongKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCTHangTrongKho = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartHangTrongKho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHangTrongKho)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartHangTrongKho
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartHangTrongKho.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartHangTrongKho.Legends.Add(legend1);
            this.ChartHangTrongKho.Location = new System.Drawing.Point(3, 59);
            this.ChartHangTrongKho.Name = "ChartHangTrongKho";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Mặt hàng";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ChartHangTrongKho.Series.Add(series1);
            this.ChartHangTrongKho.Size = new System.Drawing.Size(354, 369);
            this.ChartHangTrongKho.TabIndex = 0;
            this.ChartHangTrongKho.Text = "Hàng trong kho";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCTHangTrongKho);
            this.panel1.Location = new System.Drawing.Point(363, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 369);
            this.panel1.TabIndex = 1;
            // 
            // dgvCTHangTrongKho
            // 
            this.dgvCTHangTrongKho.AllowDrop = true;
            this.dgvCTHangTrongKho.AllowUserToOrderColumns = true;
            this.dgvCTHangTrongKho.AllowUserToResizeColumns = false;
            this.dgvCTHangTrongKho.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTHangTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHangTrongKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHangTrongKho.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHangTrongKho.Name = "dgvCTHangTrongKho";
            this.dgvCTHangTrongKho.Size = new System.Drawing.Size(396, 369);
            this.dgvCTHangTrongKho.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(363, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 50);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết sản phẩm trong kho";
            // 
            // UC_HangTrongKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ChartHangTrongKho);
            this.Name = "UC_HangTrongKho";
            this.Size = new System.Drawing.Size(762, 475);
            this.Load += new System.EventHandler(this.UC_HangTrongKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartHangTrongKho)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHangTrongKho)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartHangTrongKho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCTHangTrongKho;
    }
}
