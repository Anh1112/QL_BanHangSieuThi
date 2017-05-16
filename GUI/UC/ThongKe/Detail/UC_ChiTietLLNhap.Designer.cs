namespace GUI.UC.ThongKe.Detail
{
    partial class UC_ChiTietLLNhap
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
            this.dgvChiTietLLNhap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLLNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiTietLLNhap
            // 
            this.dgvChiTietLLNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChiTietLLNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietLLNhap.Location = new System.Drawing.Point(0, 94);
            this.dgvChiTietLLNhap.Name = "dgvChiTietLLNhap";
            this.dgvChiTietLLNhap.Size = new System.Drawing.Size(762, 381);
            this.dgvChiTietLLNhap.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 85);
            this.panel1.TabIndex = 1;
            // 
            // UC_ChiTietLLNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvChiTietLLNhap);
            this.Name = "UC_ChiTietLLNhap";
            this.Size = new System.Drawing.Size(762, 475);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietLLNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiTietLLNhap;
        private System.Windows.Forms.Panel panel1;
    }
}
