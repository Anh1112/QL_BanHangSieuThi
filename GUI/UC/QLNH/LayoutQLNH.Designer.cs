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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChiTietNhapKho = new GUI.Class.btnSimple();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.btnNhapKho = new GUI.Class.btnSimple();
            this.panel1.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(384, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 472);
            this.panel3.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 472);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnChiTietNhapKho);
            this.panel1.Location = new System.Drawing.Point(384, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 29);
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
            this.ToolBar.Size = new System.Drawing.Size(378, 29);
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
            // LayoutQLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.Name = "LayoutQLNH";
            this.Size = new System.Drawing.Size(769, 510);
            this.panel1.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Class.btnSimple btnChiTietNhapKho;
        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnNhapKho;
    }
}
