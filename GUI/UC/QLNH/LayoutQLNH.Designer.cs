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
            this.ToolBar = new System.Windows.Forms.Panel();
            this.btn_newnk = new GUI.Class.btnSimple();
            this.btnNhapKho = new GUI.Class.btnSimple();
            this.btnChiTietNhapKho = new GUI.Class.btnSimple();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_newCTnk = new GUI.Class.btnSimple();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_CTnhapkho = new System.Windows.Forms.Panel();
            this.dgv_CTnhapkho = new System.Windows.Forms.DataGridView();
            this.pnl_nhapkho = new System.Windows.Forms.Panel();
            this.dgv_nhapkho = new System.Windows.Forms.DataGridView();
            this.ToolBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_CTnhapkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTnhapkho)).BeginInit();
            this.pnl_nhapkho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btn_newnk);
            this.ToolBar.Controls.Add(this.btnNhapKho);
            this.ToolBar.Location = new System.Drawing.Point(3, 3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(408, 29);
            this.ToolBar.TabIndex = 15;
            // 
            // btn_newnk
            // 
            this.btn_newnk.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_newnk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_newnk.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btn_newnk.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btn_newnk.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_newnk.ForeColor = System.Drawing.Color.White;
            this.btn_newnk.Location = new System.Drawing.Point(362, -3);
            this.btn_newnk.Name = "btn_newnk";
            this.btn_newnk.Size = new System.Drawing.Size(46, 32);
            this.btn_newnk.TabIndex = 2;
            this.btn_newnk.TabStop = false;
            this.btn_newnk.Text = "Thêm";
            this.btn_newnk.UseActived = true;
            this.btn_newnk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_newnk_MouseClick);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhapKho.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnNhapKho.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnNhapKho.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Location = new System.Drawing.Point(0, -3);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(205, 32);
            this.btnNhapKho.TabIndex = 1;
            this.btnNhapKho.TabStop = false;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.UseActived = true;
            // 
            // btnChiTietNhapKho
            // 
            this.btnChiTietNhapKho.Alignment = System.Drawing.StringAlignment.Center;
            this.btnChiTietNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietNhapKho.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnChiTietNhapKho.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnChiTietNhapKho.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnChiTietNhapKho.Location = new System.Drawing.Point(3, 0);
            this.btnChiTietNhapKho.Name = "btnChiTietNhapKho";
            this.btnChiTietNhapKho.Size = new System.Drawing.Size(195, 29);
            this.btnChiTietNhapKho.TabIndex = 0;
            this.btnChiTietNhapKho.TabStop = false;
            this.btnChiTietNhapKho.Text = "Chi tiết nhập kho";
            this.btnChiTietNhapKho.UseActived = true;
            this.btnChiTietNhapKho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChiTietNhapKho_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_newCTnk);
            this.panel2.Controls.Add(this.btnChiTietNhapKho);
            this.panel2.Location = new System.Drawing.Point(414, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 29);
            this.panel2.TabIndex = 16;
            // 
            // btn_newCTnk
            // 
            this.btn_newCTnk.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_newCTnk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_newCTnk.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btn_newCTnk.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btn_newCTnk.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_newCTnk.ForeColor = System.Drawing.Color.White;
            this.btn_newCTnk.Location = new System.Drawing.Point(291, 0);
            this.btn_newCTnk.Name = "btn_newCTnk";
            this.btn_newCTnk.Size = new System.Drawing.Size(46, 32);
            this.btn_newCTnk.TabIndex = 3;
            this.btn_newCTnk.TabStop = false;
            this.btn_newCTnk.Text = "Thêm";
            this.btn_newCTnk.UseActived = true;
            this.btn_newCTnk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_newCTnk_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_CTnhapkho);
            this.panel1.Controls.Add(this.pnl_nhapkho);
            this.panel1.Location = new System.Drawing.Point(6, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 458);
            this.panel1.TabIndex = 17;
            // 
            // pnl_CTnhapkho
            // 
            this.pnl_CTnhapkho.Controls.Add(this.dgv_CTnhapkho);
            this.pnl_CTnhapkho.Location = new System.Drawing.Point(417, 3);
            this.pnl_CTnhapkho.Name = "pnl_CTnhapkho";
            this.pnl_CTnhapkho.Size = new System.Drawing.Size(328, 457);
            this.pnl_CTnhapkho.TabIndex = 17;
            // 
            // dgv_CTnhapkho
            // 
            this.dgv_CTnhapkho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_CTnhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTnhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CTnhapkho.Location = new System.Drawing.Point(0, 0);
            this.dgv_CTnhapkho.Name = "dgv_CTnhapkho";
            this.dgv_CTnhapkho.Size = new System.Drawing.Size(328, 457);
            this.dgv_CTnhapkho.TabIndex = 0;
            this.dgv_CTnhapkho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CTnhapkho_CellDoubleClick);
            this.dgv_CTnhapkho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_CTnhapkho_KeyUp);
            // 
            // pnl_nhapkho
            // 
            this.pnl_nhapkho.Controls.Add(this.dgv_nhapkho);
            this.pnl_nhapkho.Location = new System.Drawing.Point(3, 3);
            this.pnl_nhapkho.Name = "pnl_nhapkho";
            this.pnl_nhapkho.Size = new System.Drawing.Size(408, 457);
            this.pnl_nhapkho.TabIndex = 16;
            // 
            // dgv_nhapkho
            // 
            this.dgv_nhapkho.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_nhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhapkho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhapkho.Location = new System.Drawing.Point(0, 0);
            this.dgv_nhapkho.Name = "dgv_nhapkho";
            this.dgv_nhapkho.Size = new System.Drawing.Size(408, 457);
            this.dgv_nhapkho.TabIndex = 1;
            this.dgv_nhapkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapkho_CellClick);
            this.dgv_nhapkho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhapkho_CellDoubleClick);
            this.dgv_nhapkho.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_nhapkho_KeyUp);
            // 
            // LayoutQLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.panel2);
            this.Name = "LayoutQLNH";
            this.Size = new System.Drawing.Size(762, 510);
            this.Load += new System.EventHandler(this.LayoutQLNH_Load);
            this.ToolBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_CTnhapkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTnhapkho)).EndInit();
            this.pnl_nhapkho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhapkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnChiTietNhapKho;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_nhapkho;
        private System.Windows.Forms.DataGridView dgv_nhapkho;
        private System.Windows.Forms.Panel pnl_CTnhapkho;
        private System.Windows.Forms.DataGridView dgv_CTnhapkho;
        private Class.btnSimple btnNhapKho;
        private Class.btnSimple btn_newnk;
        private Class.btnSimple btn_newCTnk;
    }
}
