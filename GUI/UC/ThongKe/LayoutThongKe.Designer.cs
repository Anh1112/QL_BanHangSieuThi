namespace GUI.UC.ThongKe
{
    partial class LayoutThongKe
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
            this.btnNhap = new GUI.Class.btnSimple();
            this.btnTKBan = new GUI.Class.btnSimple();
            this.btnHangTrongKho = new GUI.Class.btnSimple();
            this.RenderBody = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btnNhap);
            this.ToolBar.Controls.Add(this.btnTKBan);
            this.ToolBar.Controls.Add(this.btnHangTrongKho);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(769, 26);
            this.ToolBar.TabIndex = 1;
            // 
            // btnNhap
            // 
            this.btnNhap.Alignment = System.Drawing.StringAlignment.Center;
            this.btnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhap.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnNhap.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnNhap.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Location = new System.Drawing.Point(210, 0);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(113, 26);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.TabStop = false;
            this.btnNhap.Text = "Lưu lượng nhập";
            this.btnNhap.UseActived = true;
            this.btnNhap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNhap_MouseClick);
            // 
            // btnTKBan
            // 
            this.btnTKBan.Alignment = System.Drawing.StringAlignment.Center;
            this.btnTKBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnTKBan.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnTKBan.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnTKBan.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnTKBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTKBan.ForeColor = System.Drawing.Color.White;
            this.btnTKBan.Location = new System.Drawing.Point(97, 0);
            this.btnTKBan.Name = "btnTKBan";
            this.btnTKBan.Size = new System.Drawing.Size(113, 26);
            this.btnTKBan.TabIndex = 1;
            this.btnTKBan.TabStop = false;
            this.btnTKBan.Text = "Mức tiêu thụ";
            this.btnTKBan.UseActived = true;
            this.btnTKBan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTKBan_MouseClick);
            // 
            // btnHangTrongKho
            // 
            this.btnHangTrongKho.Alignment = System.Drawing.StringAlignment.Center;
            this.btnHangTrongKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnHangTrongKho.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnHangTrongKho.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnHangTrongKho.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnHangTrongKho.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHangTrongKho.ForeColor = System.Drawing.Color.White;
            this.btnHangTrongKho.Location = new System.Drawing.Point(0, 0);
            this.btnHangTrongKho.Name = "btnHangTrongKho";
            this.btnHangTrongKho.Size = new System.Drawing.Size(97, 26);
            this.btnHangTrongKho.TabIndex = 0;
            this.btnHangTrongKho.TabStop = false;
            this.btnHangTrongKho.Text = "Hàng trong kho";
            this.btnHangTrongKho.UseActived = true;
            this.btnHangTrongKho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHangTrongKho_MouseClick);
            // 
            // RenderBody
            // 
            this.RenderBody.Location = new System.Drawing.Point(4, 32);
            this.RenderBody.Name = "RenderBody";
            this.RenderBody.Size = new System.Drawing.Size(762, 475);
            this.RenderBody.TabIndex = 4;
            // 
            // LayoutThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RenderBody);
            this.Controls.Add(this.ToolBar);
            this.Name = "LayoutThongKe";
            this.Size = new System.Drawing.Size(769, 510);
            this.ToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnTKBan;
        private Class.btnSimple btnHangTrongKho;
        private Class.btnSimple btnNhap;
        private System.Windows.Forms.Panel RenderBody;
    }
}
