namespace GUI.UC.QLNL
{
    partial class Layout_QLNL
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
            this.btnKhachHang = new GUI.Class.btnSimple();
            this.btnNhanVien = new GUI.Class.btnSimple();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btnKhachHang);
            this.ToolBar.Controls.Add(this.btnNhanVien);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(769, 26);
            this.ToolBar.TabIndex = 1;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Alignment = System.Drawing.StringAlignment.Center;
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnKhachHang.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnKhachHang.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnKhachHang.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(96, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(85, 26);
            this.btnKhachHang.TabIndex = 1;
            this.btnKhachHang.TabStop = false;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseActived = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhanVien.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnNhanVien.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnNhanVien.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(96, 26);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.TabStop = false;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseActived = true;
            // 
            // Layout_QLNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolBar);
            this.Name = "Layout_QLNL";
            this.Size = new System.Drawing.Size(769, 510);
            this.ToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnKhachHang;
        private Class.btnSimple btnNhanVien;
    }
}
