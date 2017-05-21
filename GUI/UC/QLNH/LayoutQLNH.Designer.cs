namespace GUI.UC.QLNH
{
    partial class LayoutQLNH
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
            this.pnl_CTnhapkho = new System.Windows.Forms.Panel();
            this.pnl_nhapkho = new System.Windows.Forms.Panel();
            this.dgv_nhapkho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTietNhapKho = new GUI.Class.btnSimple();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.btnNhapKho = new GUI.Class.btnSimple();
            this.dgv_CTnhapkho = new System.Windows.Forms.DataGridView();
            this.pnl_CTnhapkho.SuspendLayout();
            this.pnl_nhapkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho)).BeginInit();
            this.panel1.SuspendLayout();
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTnhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_CTnhapkho
            // 
            this.pnl_CTnhapkho.Controls.Add(this.dgv_CTnhapkho);
            this.pnl_CTnhapkho.Location = new System.Drawing.Point(414, 35);
            this.pnl_CTnhapkho.Name = "pnl_CTnhapkho";
            this.pnl_CTnhapkho.Size = new System.Drawing.Size(348, 472);
            this.pnl_CTnhapkho.TabIndex = 8;
            // 
            // pnl_nhapkho
            // 
            this.pnl_nhapkho.Controls.Add(this.dgv_nhapkho);
            this.pnl_nhapkho.Location = new System.Drawing.Point(3, 35);
            this.pnl_nhapkho.Name = "pnl_nhapkho";
            this.pnl_nhapkho.Size = new System.Drawing.Size(408, 472);
            this.pnl_nhapkho.TabIndex = 7;
            // 
            // dgv_nhapkho
            // 
            this.dgv_nhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhapkho.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhapkho.Name = "dgv_nhapkho";
            this.dgv_nhapkho.Size = new System.Drawing.Size(408, 472);
            this.dgv_nhapkho.TabIndex = 1;
            this.dgv_nhapkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapkho_CellClick);
            this.dgv_nhapkho.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapkho_CellEndEdit);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnChiTietNhapKho);
            this.panel1.Location = new System.Drawing.Point(414, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 29);
            this.panel1.TabIndex = 6;
            // 
            // btnChiTietNhapKho
            // 
            this.btnChiTietNhapKho.Alignment = System.Drawing.StringAlignment.Center;
            this.btnChiTietNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietNhapKho.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnChiTietNhapKho.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnChiTietNhapKho.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnChiTietNhapKho.Location = new System.Drawing.Point(3, 3);
            this.btnChiTietNhapKho.Name = "btnChiTietNhapKho";
            this.btnChiTietNhapKho.Size = new System.Drawing.Size(195, 26);
            this.btnChiTietNhapKho.TabIndex = 0;
            this.btnChiTietNhapKho.TabStop = false;
            this.btnChiTietNhapKho.Text = "Chi tiết nhập kho";
            this.btnChiTietNhapKho.UseActived = true;
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btnNhapKho);
            this.ToolBar.Location = new System.Drawing.Point(3, 3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(408, 29);
            this.ToolBar.TabIndex = 5;
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhapKho.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnNhapKho.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnNhapKho.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(0, 0);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(195, 26);
            this.btnNhapKho.TabIndex = 0;
            this.btnNhapKho.TabStop = false;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseActived = true;
            // 
            // dgv_CTnhapkho
            // 
            this.dgv_CTnhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTnhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CTnhapkho.Location = new System.Drawing.Point(0, 0);
            this.dgv_CTnhapkho.Name = "dgv_CTnhapkho";
            this.dgv_CTnhapkho.Size = new System.Drawing.Size(348, 472);
            this.dgv_CTnhapkho.TabIndex = 0;
            // 
            // LayoutQLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_CTnhapkho);
            this.Controls.Add(this.pnl_nhapkho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Name = "LayoutQLNH";
            this.Size = new System.Drawing.Size(769, 510);
            this.Load += new System.EventHandler(this.LayoutQLNH_Load);
            this.pnl_CTnhapkho.ResumeLayout(false);
            this.pnl_nhapkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTnhapkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_CTnhapkho;
        private System.Windows.Forms.Panel pnl_nhapkho;
        private System.Windows.Forms.Panel panel1;
        private Class.btnSimple btnChiTietNhapKho;
        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnNhapKho;
        private System.Windows.Forms.DataGridView dgv_nhapkho;
        private System.Windows.Forms.DataGridView dgv_CTnhapkho;
    }
}
