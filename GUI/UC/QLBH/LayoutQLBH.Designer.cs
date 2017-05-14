namespace GUI.UC.QLBH
{
    partial class LayoutQLBH
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
            this.btnHoaDon = new GUI.Class.btnSimple();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTietHoaDon = new GUI.Class.btnSimple();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btnHoaDon);
            this.ToolBar.Location = new System.Drawing.Point(3, 3);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(378, 29);
            this.ToolBar.TabIndex = 1;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Alignment = System.Drawing.StringAlignment.Center;
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnHoaDon.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnHoaDon.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnHoaDon.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(195, 26);
            this.btnHoaDon.TabIndex = 0;
            this.btnHoaDon.TabStop = false;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseActived = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnChiTietHoaDon);
            this.panel1.Location = new System.Drawing.Point(384, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 29);
            this.panel1.TabIndex = 2;
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.Alignment = System.Drawing.StringAlignment.Center;
            this.btnChiTietHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietHoaDon.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnChiTietHoaDon.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnChiTietHoaDon.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnChiTietHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(195, 26);
            this.btnChiTietHoaDon.TabIndex = 0;
            this.btnChiTietHoaDon.TabStop = false;
            this.btnChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.btnChiTietHoaDon.UseActived = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 472);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(384, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 472);
            this.panel3.TabIndex = 4;
            // 
            // LayoutQLBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Name = "LayoutQLBH";
            this.Size = new System.Drawing.Size(769, 510);
            this.ToolBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnHoaDon;
        private System.Windows.Forms.Panel panel1;
        private Class.btnSimple btnChiTietHoaDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
