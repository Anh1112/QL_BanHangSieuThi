namespace GUI.UC.TimKiem
{
    partial class LayoutTimKiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchgia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerchhang = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchGiaNhap = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlSearch);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 55);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSearchgia);
            this.panel5.Location = new System.Drawing.Point(363, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(158, 24);
            this.panel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "";
            // 
            // txtSearchgia
            // 
            this.txtSearchgia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchgia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchgia.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchgia.Location = new System.Drawing.Point(8, 5);
            this.txtSearchgia.Name = "txtSearchgia";
            this.txtSearchgia.Size = new System.Drawing.Size(118, 13);
            this.txtSearchgia.TabIndex = 0;
            this.txtSearchgia.TabStop = false;
            this.txtSearchgia.Text = "nhập giá bán...";
            this.txtSearchgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchgia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchgia_MouseClick);
            this.txtSearchgia.TextChanged += new System.EventHandler(this.txtSearchgia_TextChanged);
            this.txtSearchgia.MouseLeave += new System.EventHandler(this.txtSearchgia_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSerchhang);
            this.panel3.Location = new System.Drawing.Point(191, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 24);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "";
            // 
            // txtSerchhang
            // 
            this.txtSerchhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerchhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerchhang.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSerchhang.Location = new System.Drawing.Point(8, 5);
            this.txtSerchhang.Name = "txtSerchhang";
            this.txtSerchhang.Size = new System.Drawing.Size(118, 13);
            this.txtSerchhang.TabIndex = 0;
            this.txtSerchhang.TabStop = false;
            this.txtSerchhang.Text = "nhập hãng...";
            this.txtSerchhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSerchhang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSerchhang_MouseClick);
            this.txtSerchhang.TextChanged += new System.EventHandler(this.txtSerchhang_TextChanged);
            this.txtSerchhang.MouseLeave += new System.EventHandler(this.txtSerchhang_MouseLeave);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.labSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(17, 16);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(158, 24);
            this.pnlSearch.TabIndex = 1;
            // 
            // labSearch
            // 
            this.labSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(132, 5);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(20, 13);
            this.labSearch.TabIndex = 1;
            this.labSearch.Text = "";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(8, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(118, 13);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "nhập tên...";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTimKiem);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 449);
            this.panel2.TabIndex = 1;
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.dgvTimKiem.AllowUserToAddRows = false;
            this.dgvTimKiem.AllowUserToDeleteRows = false;
            this.dgvTimKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiem.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTimKiem.Location = new System.Drawing.Point(0, 1);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.ReadOnly = true;
            this.dgvTimKiem.Size = new System.Drawing.Size(745, 448);
            this.dgvTimKiem.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSearchGiaNhap);
            this.panel4.Location = new System.Drawing.Point(537, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 24);
            this.panel4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "";
            // 
            // txtSearchGiaNhap
            // 
            this.txtSearchGiaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchGiaNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchGiaNhap.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchGiaNhap.Location = new System.Drawing.Point(8, 5);
            this.txtSearchGiaNhap.Name = "txtSearchGiaNhap";
            this.txtSearchGiaNhap.Size = new System.Drawing.Size(118, 13);
            this.txtSearchGiaNhap.TabIndex = 0;
            this.txtSearchGiaNhap.TabStop = false;
            this.txtSearchGiaNhap.Text = "nhập giá nhập...";
            this.txtSearchGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchGiaNhap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchGiaNhap_MouseClick);
            this.txtSearchGiaNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearchGiaNhap.MouseLeave += new System.EventHandler(this.txtSearchGiaNhap_MouseLeave);
            // 
            // LayoutTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LayoutTimKiem";
            this.Size = new System.Drawing.Size(748, 510);
            this.Load += new System.EventHandler(this.LayoutTimKiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerchhang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchgia;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchGiaNhap;
    }
}
