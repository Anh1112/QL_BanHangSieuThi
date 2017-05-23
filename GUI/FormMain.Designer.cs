namespace GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ToolBar = new System.Windows.Forms.Panel();
            this.labLogo2 = new System.Windows.Forms.Label();
            this.labLogo1 = new System.Windows.Forms.Label();
            this.btnMinimize = new GUI.Class.btnSimple();
            this.btnMaximize = new GUI.Class.btnSimple();
            this.btnClose = new GUI.Class.btnSimple();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTroGiup = new GUI.Class.btnImage();
            this.btnTK = new GUI.Class.btnImage();
            this.btnQLNL = new GUI.Class.btnImage();
            this.btnQLBH = new GUI.Class.btnImage();
            this.btnQLNH = new GUI.Class.btnImage();
            this.btnQLHH = new GUI.Class.btnImage();
            this.btnTimKiem = new GUI.Class.btnImage();
            this.btnMenu = new GUI.Class.btnImage();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.RenderBody = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Turquoise;
            this.ToolBar.Controls.Add(this.labLogo2);
            this.ToolBar.Controls.Add(this.labLogo1);
            this.ToolBar.Controls.Add(this.btnMinimize);
            this.ToolBar.Controls.Add(this.btnMaximize);
            this.ToolBar.Controls.Add(this.btnClose);
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(960, 30);
            this.ToolBar.TabIndex = 1;
            this.ToolBar.Paint += new System.Windows.Forms.PaintEventHandler(this.ToolBar_Paint);
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseup);
            // 
            // labLogo2
            // 
            this.labLogo2.AutoSize = true;
            this.labLogo2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogo2.ForeColor = System.Drawing.Color.White;
            this.labLogo2.Location = new System.Drawing.Point(58, 7);
            this.labLogo2.Name = "labLogo2";
            this.labLogo2.Size = new System.Drawing.Size(49, 17);
            this.labLogo2.TabIndex = 4;
            this.labLogo2.Text = "Project";
            // 
            // labLogo1
            // 
            this.labLogo1.AutoSize = true;
            this.labLogo1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogo1.ForeColor = System.Drawing.Color.White;
            this.labLogo1.Location = new System.Drawing.Point(1, -6);
            this.labLogo1.Name = "labLogo1";
            this.labLogo1.Size = new System.Drawing.Size(61, 36);
            this.labLogo1.TabIndex = 3;
            this.labLogo1.Text = "LHA";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Alignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.btnMinimize.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnMinimize.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(870, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "0";
            this.btnMinimize.UseActived = false;
            this.btnMinimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMinimize_MouseClick);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Alignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.btnMaximize.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnMaximize.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(900, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Text = "1";
            this.btnMaximize.UseActived = false;
            this.btnMaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMaximize_MouseClick);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Drawing.StringAlignment.Center;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.btnClose.ColorMouseEnter = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(183)))), ((int)(((byte)(194)))));
            this.btnClose.ColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(930, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "r";
            this.btnClose.UseActived = false;
            this.btnClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseClick);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Honeydew;
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.pnlPicture);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 30);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(191, 510);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnTroGiup);
            this.pnlMenu.Controls.Add(this.btnTK);
            this.pnlMenu.Controls.Add(this.btnQLNL);
            this.pnlMenu.Controls.Add(this.btnQLBH);
            this.pnlMenu.Controls.Add(this.btnQLNH);
            this.pnlMenu.Controls.Add(this.btnQLHH);
            this.pnlMenu.Controls.Add(this.btnTimKiem);
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(191, 390);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.BackColor = System.Drawing.Color.Transparent;
            this.btnTroGiup.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnTroGiup.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnTroGiup.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnTroGiup.ImageMouseDown = null;
            this.btnTroGiup.ImageMouseEnter = null;
            this.btnTroGiup.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.ImageMouseLeave")));
            this.btnTroGiup.ImgMargin = 8;
            this.btnTroGiup.ImgSize = new System.Drawing.Size(25, 25);
            this.btnTroGiup.Location = new System.Drawing.Point(0, 342);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(190, 45);
            this.btnTroGiup.TabIndex = 33;
            this.btnTroGiup.TabStop = false;
            this.btnTroGiup.Text = "     Trợ giúp";
            this.btnTroGiup.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnTroGiup.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnTroGiup.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnTroGiup.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnTroGiup.UseActived = true;
            this.btnTroGiup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTroGiup_MouseClick);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTK.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnTK.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnTK.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnTK.ImageMouseDown = null;
            this.btnTK.ImageMouseEnter = null;
            this.btnTK.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnTK.ImageMouseLeave")));
            this.btnTK.ImgMargin = 8;
            this.btnTK.ImgSize = new System.Drawing.Size(25, 25);
            this.btnTK.Location = new System.Drawing.Point(1, 291);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(190, 45);
            this.btnTK.TabIndex = 32;
            this.btnTK.TabStop = false;
            this.btnTK.Text = "     Thống kê";
            this.btnTK.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnTK.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnTK.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnTK.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnTK.UseActived = true;
            this.btnTK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTK_MouseClick);
            // 
            // btnQLNL
            // 
            this.btnQLNL.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNL.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnQLNL.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnQLNL.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNL.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnQLNL.ImageMouseDown = null;
            this.btnQLNL.ImageMouseEnter = null;
            this.btnQLNL.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnQLNL.ImageMouseLeave")));
            this.btnQLNL.ImgMargin = 8;
            this.btnQLNL.ImgSize = new System.Drawing.Size(25, 25);
            this.btnQLNL.Location = new System.Drawing.Point(0, 240);
            this.btnQLNL.Name = "btnQLNL";
            this.btnQLNL.Size = new System.Drawing.Size(190, 45);
            this.btnQLNL.TabIndex = 31;
            this.btnQLNL.TabStop = false;
            this.btnQLNL.Text = "     Quản lí nhân lực";
            this.btnQLNL.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnQLNL.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnQLNL.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnQLNL.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnQLNL.UseActived = true;
            this.btnQLNL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLNL_MouseClick);
            // 
            // btnQLBH
            // 
            this.btnQLBH.BackColor = System.Drawing.Color.Transparent;
            this.btnQLBH.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnQLBH.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnQLBH.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBH.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnQLBH.ImageMouseDown = null;
            this.btnQLBH.ImageMouseEnter = null;
            this.btnQLBH.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnQLBH.ImageMouseLeave")));
            this.btnQLBH.ImgMargin = 8;
            this.btnQLBH.ImgSize = new System.Drawing.Size(25, 25);
            this.btnQLBH.Location = new System.Drawing.Point(0, 189);
            this.btnQLBH.Name = "btnQLBH";
            this.btnQLBH.Size = new System.Drawing.Size(190, 45);
            this.btnQLBH.TabIndex = 30;
            this.btnQLBH.TabStop = false;
            this.btnQLBH.Text = "     Quản lý bán hàng";
            this.btnQLBH.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnQLBH.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnQLBH.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnQLBH.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnQLBH.UseActived = true;
            this.btnQLBH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLBH_MouseClick);
            // 
            // btnQLNH
            // 
            this.btnQLNH.BackColor = System.Drawing.Color.Transparent;
            this.btnQLNH.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnQLNH.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnQLNH.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNH.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnQLNH.ImageMouseDown = null;
            this.btnQLNH.ImageMouseEnter = null;
            this.btnQLNH.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnQLNH.ImageMouseLeave")));
            this.btnQLNH.ImgMargin = 8;
            this.btnQLNH.ImgSize = new System.Drawing.Size(25, 25);
            this.btnQLNH.Location = new System.Drawing.Point(-2, 138);
            this.btnQLNH.Name = "btnQLNH";
            this.btnQLNH.Size = new System.Drawing.Size(190, 45);
            this.btnQLNH.TabIndex = 29;
            this.btnQLNH.TabStop = false;
            this.btnQLNH.Text = "    Quản lí nhập hàng";
            this.btnQLNH.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnQLNH.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnQLNH.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnQLNH.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnQLNH.UseActived = true;
            this.btnQLNH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLNH_MouseClick);
            // 
            // btnQLHH
            // 
            this.btnQLHH.BackColor = System.Drawing.Color.Transparent;
            this.btnQLHH.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnQLHH.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnQLHH.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnQLHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHH.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnQLHH.ImageMouseDown = null;
            this.btnQLHH.ImageMouseEnter = null;
            this.btnQLHH.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnQLHH.ImageMouseLeave")));
            this.btnQLHH.ImgMargin = 8;
            this.btnQLHH.ImgSize = new System.Drawing.Size(25, 25);
            this.btnQLHH.Location = new System.Drawing.Point(3, 95);
            this.btnQLHH.Name = "btnQLHH";
            this.btnQLHH.Size = new System.Drawing.Size(190, 37);
            this.btnQLHH.TabIndex = 28;
            this.btnQLHH.TabStop = false;
            this.btnQLHH.Text = "     Quản lý hàng hóa";
            this.btnQLHH.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnQLHH.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnQLHH.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnQLHH.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnQLHH.UseActived = true;
            this.btnQLHH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnQLHH_MouseClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnTimKiem.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnTimKiem.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnTimKiem.ImageMouseDown = null;
            this.btnTimKiem.ImageMouseEnter = null;
            this.btnTimKiem.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageMouseLeave")));
            this.btnTimKiem.ImgMargin = 8;
            this.btnTimKiem.ImgSize = new System.Drawing.Size(25, 25);
            this.btnTimKiem.Location = new System.Drawing.Point(0, 52);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 37);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.TabStop = false;
            this.btnTimKiem.Text = "     Tìm sản phẩm";
            this.btnTimKiem.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnTimKiem.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnTimKiem.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnTimKiem.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnTimKiem.UseActived = true;
            this.btnTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTimKiem_MouseClick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BgrColorMouseDown = System.Drawing.Color.PowderBlue;
            this.btnMenu.BgrColorMouseEnter = System.Drawing.Color.PowderBlue;
            this.btnMenu.BgrColorMouseLeave = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ImageAlignment = GUI.Class.btnImage.Image_Alignment.LeftText;
            this.btnMenu.ImageMouseDown = null;
            this.btnMenu.ImageMouseEnter = null;
            this.btnMenu.ImageMouseLeave = ((System.Drawing.Image)(resources.GetObject("btnMenu.ImageMouseLeave")));
            this.btnMenu.ImgMargin = 8;
            this.btnMenu.ImgSize = new System.Drawing.Size(25, 25);
            this.btnMenu.Location = new System.Drawing.Point(-2, 11);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(190, 35);
            this.btnMenu.TabIndex = 26;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "     Menu";
            this.btnMenu.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnMenu.TextColorMouseDown = System.Drawing.Color.Empty;
            this.btnMenu.TextColorMouseEnter = System.Drawing.Color.Empty;
            this.btnMenu.TextColorMouseLeave = System.Drawing.Color.Black;
            this.btnMenu.UseActived = false;
            this.btnMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseClick);
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.picLogo);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(191, 80);
            this.pnlPicture.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(45, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(94, 61);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 19;
            this.picLogo.TabStop = false;
            // 
            // RenderBody
            // 
            this.RenderBody.BackColor = System.Drawing.Color.White;
            this.RenderBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RenderBody.Location = new System.Drawing.Point(191, 30);
            this.RenderBody.Name = "RenderBody";
            this.RenderBody.Size = new System.Drawing.Size(769, 510);
            this.RenderBody.TabIndex = 3;
            this.RenderBody.Paint += new System.Windows.Forms.PaintEventHandler(this.RenderBody_Paint);
            this.RenderBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseDown);
            this.RenderBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.changenk_MouseMove);
            this.RenderBody.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.RenderBody);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Label labLogo2;
        private System.Windows.Forms.Label labLogo1;
        private Class.btnSimple btnMinimize;
        private Class.btnSimple btnMaximize;
        private Class.btnSimple btnClose;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMenu;
        private Class.btnImage btnTK;
        private Class.btnImage btnQLNL;
        private Class.btnImage btnQLBH;
        private Class.btnImage btnQLNH;
        private Class.btnImage btnQLHH;
        private Class.btnImage btnTimKiem;
        private Class.btnImage btnMenu;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel RenderBody;
        private Class.btnImage btnTroGiup;
    }
}