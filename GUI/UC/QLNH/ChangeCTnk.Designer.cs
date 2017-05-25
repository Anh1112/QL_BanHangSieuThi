namespace GUI.UC.QLNH
{
    partial class ChangeCTnk
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
            this.btn_minimize = new GUI.Class.btnSimple();
            this.btn_thoat = new GUI.Class.btnSimple();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_mahang = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.btn_luu = new GUI.Class.btnSimple();
            this.btn_huy = new GUI.Class.btnSimple();
            this.ts = new System.Windows.Forms.Timer(this.components);
            this.txt_mank = new System.Windows.Forms.TextBox();
            this.lbl_chedo = new System.Windows.Forms.Label();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Turquoise;
            this.ToolBar.Controls.Add(this.labLogo2);
            this.ToolBar.Controls.Add(this.btn_minimize);
            this.ToolBar.Controls.Add(this.btn_thoat);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(462, 30);
            this.ToolBar.TabIndex = 3;
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
            this.labLogo2.Size = new System.Drawing.Size(108, 17);
            this.labLogo2.TabIndex = 5;
            this.labLogo2.Text = "Chi Tiết Kho Hàng";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_minimize.BackColor = System.Drawing.Color.Turquoise;
            this.btn_minimize.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btn_minimize.ColorMouseEnter = System.Drawing.Color.Aqua;
            this.btn_minimize.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(379, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(36, 30);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseActived = false;
            this.btn_minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSimple2_MouseClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_thoat.BackColor = System.Drawing.Color.Turquoise;
            this.btn_thoat.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btn_thoat.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_thoat.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(421, 0);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(36, 30);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "X";
            this.btn_thoat.UseActived = false;
            this.btn_thoat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSimple1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(54, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giá Nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(54, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(52, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã Mặt Hàng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(54, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã Nhập Kho :";
            // 
            // cbb_mahang
            // 
            this.cbb_mahang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_mahang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_mahang.FormattingEnabled = true;
            this.cbb_mahang.Location = new System.Drawing.Point(180, 134);
            this.cbb_mahang.Name = "cbb_mahang";
            this.cbb_mahang.Size = new System.Drawing.Size(167, 21);
            this.cbb_mahang.TabIndex = 11;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(180, 184);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(167, 20);
            this.txt_soluong.TabIndex = 12;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(180, 236);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(167, 20);
            this.txt_gianhap.TabIndex = 13;
            // 
            // btn_luu
            // 
            this.btn_luu.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_luu.BackColor = System.Drawing.Color.Turquoise;
            this.btn_luu.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btn_luu.ColorMouseEnter = System.Drawing.Color.Aqua;
            this.btn_luu.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(379, 295);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(53, 30);
            this.btn_luu.TabIndex = 15;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseActived = false;
            // 
            // btn_huy
            // 
            this.btn_huy.Alignment = System.Drawing.StringAlignment.Center;
            this.btn_huy.BackColor = System.Drawing.Color.Turquoise;
            this.btn_huy.ColorMouseDown = System.Drawing.Color.Cyan;
            this.btn_huy.ColorMouseEnter = System.Drawing.Color.Aqua;
            this.btn_huy.ColorMouseLeave = System.Drawing.Color.Turquoise;
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Location = new System.Drawing.Point(320, 295);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(53, 30);
            this.btn_huy.TabIndex = 16;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseActived = false;
            this.btn_huy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSimple4_MouseClick);
            // 
            // ts
            // 
            this.ts.Interval = 1000;
            this.ts.Tick += new System.EventHandler(this.ts_Tick);
            // 
            // txt_mank
            // 
            this.txt_mank.Location = new System.Drawing.Point(180, 85);
            this.txt_mank.Name = "txt_mank";
            this.txt_mank.Size = new System.Drawing.Size(167, 20);
            this.txt_mank.TabIndex = 17;
            // 
            // lbl_chedo
            // 
            this.lbl_chedo.AutoSize = true;
            this.lbl_chedo.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chedo.ForeColor = System.Drawing.Color.White;
            this.lbl_chedo.Location = new System.Drawing.Point(376, 46);
            this.lbl_chedo.Name = "lbl_chedo";
            this.lbl_chedo.Size = new System.Drawing.Size(54, 17);
            this.lbl_chedo.TabIndex = 18;
            this.lbl_chedo.Text = "Chi Tiết";
            // 
            // ChangeCTnk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(462, 337);
            this.Controls.Add(this.lbl_chedo);
            this.Controls.Add(this.txt_mank);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_gianhap);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.cbb_mahang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeCTnk";
            this.Text = "ChangeCTnk";
            this.Load += new System.EventHandler(this.ChangeCTnk_Load);
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
        private System.Windows.Forms.Label labLogo2;
        private Class.btnSimple btn_minimize;
        private Class.btnSimple btn_thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_mahang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_gianhap;
        private Class.btnSimple btn_luu;
        private Class.btnSimple btn_huy;
        private System.Windows.Forms.Timer ts;
        private System.Windows.Forms.TextBox txt_mank;
        private System.Windows.Forms.Label lbl_chedo;
    }
}