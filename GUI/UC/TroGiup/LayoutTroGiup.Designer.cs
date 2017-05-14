namespace GUI.UC.TroGiup
{
    partial class LayoutTroGiup
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
            this.btnGioiThieu = new GUI.Class.btnSimple();
            this.btnTroGiup = new GUI.Class.btnSimple();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ToolBar.Controls.Add(this.btnGioiThieu);
            this.ToolBar.Controls.Add(this.btnTroGiup);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(769, 26);
            this.ToolBar.TabIndex = 2;
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Alignment = System.Drawing.StringAlignment.Center;
            this.btnGioiThieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnGioiThieu.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnGioiThieu.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnGioiThieu.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnGioiThieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGioiThieu.ForeColor = System.Drawing.Color.White;
            this.btnGioiThieu.Location = new System.Drawing.Point(83, 0);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(85, 26);
            this.btnGioiThieu.TabIndex = 1;
            this.btnGioiThieu.TabStop = false;
            this.btnGioiThieu.Text = "Giới thiệu";
            this.btnGioiThieu.UseActived = true;
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Alignment = System.Drawing.StringAlignment.Center;
            this.btnTroGiup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnTroGiup.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btnTroGiup.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btnTroGiup.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btnTroGiup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTroGiup.ForeColor = System.Drawing.Color.White;
            this.btnTroGiup.Location = new System.Drawing.Point(0, 0);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(83, 26);
            this.btnTroGiup.TabIndex = 0;
            this.btnTroGiup.TabStop = false;
            this.btnTroGiup.Text = "Trợ giúp";
            this.btnTroGiup.UseActived = true;
            // 
            // LayoutTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToolBar);
            this.Name = "LayoutTroGiup";
            this.Size = new System.Drawing.Size(769, 510);
            this.ToolBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnGioiThieu;
        private Class.btnSimple btnTroGiup;
    }
}
