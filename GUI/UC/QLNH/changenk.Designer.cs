namespace GUI.UC.QLNH
{
    partial class changenk
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToolBar = new System.Windows.Forms.Panel();
            this.labLogo2 = new System.Windows.Forms.Label();
            this.btnSimple2 = new GUI.Class.btnSimple();
            this.btnSimple1 = new GUI.Class.btnSimple();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_chedo = new System.Windows.Forms.Label();
            this.ts = new System.Windows.Forms.Timer(this.components);
            this.time_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.cbb_nvma = new System.Windows.Forms.ComboBox();
            this.btn_huy = new GUI.Class.btnSimple();
            this.btn_luu = new GUI.Class.btnSimple();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Turquoise;
            this.ToolBar.Controls.Add(this.labLogo2);
            this.ToolBar.Controls.Add(this.btnSimple2);
            this.ToolBar.Controls.Add(this.btnSimple1);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(390, 30);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseup);
            // 
            // labLogo2
            // 
            this.labLogo2.AutoSize = true;
            this.labLogo2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogo2.ForeColor = System.Drawing.Color.White;
            this.labLogo2.Location = new System.Drawing.Point(3, 9);
            this.labLogo2.Name = "labLogo2";
            this.labLogo2.Size = new System.Drawing.Size(58, 17);
            this.labLogo2.TabIndex = 5;
            this.labLogo2.Text = "Kho Hàng";
            // 
            // btnSimple2
            // 
            this.btnSimple2.Alignment = System.Drawing.StringAlignment.Center;
            this.btnSimple2.BackColor = System.Drawing.Color.Turquoise;
            this.btnSimple2.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btnSimple2.ColorMouseEnter = System.Drawing.Color.Aqua;
            this.btnSimple2.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btnSimple2.ForeColor = System.Drawing.Color.White;
            this.btnSimple2.Location = new System.Drawing.Point(307, 0);
            this.btnSimple2.Name = "btnSimple2";
            this.btnSimple2.Size = new System.Drawing.Size(36, 30);
            this.btnSimple2.TabIndex = 1;
            this.btnSimple2.Text = "-";
            this.btnSimple2.UseActived = false;
            this.btnSimple2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSimple2_MouseClick);
            // 
            // btnSimple1
            // 
            this.btnSimple1.Alignment = System.Drawing.StringAlignment.Center;
            this.btnSimple1.BackColor = System.Drawing.Color.Turquoise;
            this.btnSimple1.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btnSimple1.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSimple1.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btnSimple1.ForeColor = System.Drawing.Color.White;
            this.btnSimple1.Location = new System.Drawing.Point(349, 0);
            this.btnSimple1.Name = "btnSimple1";
            this.btnSimple1.Size = new System.Drawing.Size(36, 30);
            this.btnSimple1.TabIndex = 0;
            this.btnSimple1.Text = "X";
            this.btnSimple1.UseActived = false;
            this.btnSimple1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSimple1_MouseClick);
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(116, 75);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.Size = new System.Drawing.Size(181, 20);
            this.txt_ma.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(67, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(22, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày Nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(3, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã  Nhân Viên :";
            // 
            // lbl_chedo
            // 
            this.lbl_chedo.AutoSize = true;
            this.lbl_chedo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chedo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_chedo.Location = new System.Drawing.Point(323, 33);
            this.lbl_chedo.Name = "lbl_chedo";
            this.lbl_chedo.Size = new System.Drawing.Size(0, 17);
            this.lbl_chedo.TabIndex = 12;
            // 
            // ts
            // 
            this.ts.Enabled = true;
            this.ts.Interval = 1000;
            this.ts.Tick += new System.EventHandler(this.ts_Tick);
            // 
            // time_ngaynhap
            // 
            this.time_ngaynhap.CustomFormat = "dd/mm/yyyy";
            this.time_ngaynhap.Location = new System.Drawing.Point(116, 203);
            this.time_ngaynhap.Name = "time_ngaynhap";
            this.time_ngaynhap.Size = new System.Drawing.Size(181, 20);
            this.time_ngaynhap.TabIndex = 13;
            // 
            // cbb_nvma
            // 
            this.cbb_nvma.FormattingEnabled = true;
            this.cbb_nvma.Location = new System.Drawing.Point(116, 137);
            this.cbb_nvma.Name = "cbb_nvma";
            this.cbb_nvma.Size = new System.Drawing.Size(181, 21);
            this.cbb_nvma.TabIndex = 14;
            // 
            // btn_huy
            // 
            this.btn_huy.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_huy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_huy.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btn_huy.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btn_huy.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(194, 243);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(71, 29);
            this.btn_huy.TabIndex = 15;
            this.btn_huy.TabStop = false;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseActived = true;
            this.btn_huy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_huy_MouseClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_luu.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(139)))));
            this.btn_luu.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(168)))));
            this.btn_luu.ColorMouseLeave = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(162)))), ((int)(((byte)(151)))));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(293, 243);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(71, 29);
            this.btn_luu.TabIndex = 16;
            this.btn_luu.TabStop = false;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseActived = true;
            // 
            // changenk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(390, 290);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.cbb_nvma);
            this.Controls.Add(this.time_ngaynhap);
            this.Controls.Add(this.lbl_chedo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changenk";
            this.Text = "changenk";
            this.Load += new System.EventHandler(this.changenk_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseup);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private Class.btnSimple btnSimple1;
        private Class.btnSimple btnSimple2;
        private System.Windows.Forms.Label labLogo2;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_chedo;
        private System.Windows.Forms.Timer ts;
        private System.Windows.Forms.DateTimePicker time_ngaynhap;
        private System.Windows.Forms.ComboBox cbb_nvma;
        private Class.btnSimple btn_huy;
        private Class.btnSimple btn_luu;
    }
}