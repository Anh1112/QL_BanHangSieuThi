using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Class
{
    [System.ComponentModel.DefaultEvent("MouseClick")]
    class btnImage : UserControl
    {

        public enum Image_Alignment { LeftText, RightText }
        private string text;
        private StringAlignment txt_algn = StringAlignment.Center;
        private Color txtclr = Color.White;
        private Color txtclrMD;
        private Color txtclrME;
        private Color txtclrML = Color.White;
        private Color bgrclrMD = Color.FromArgb(26, 71, 127);
        private Color bgrclrME = Color.FromArgb(0, 122, 204);
        private Color bgrclrML;
        private Image img;
        private Image imgMD;
        private Image imgME;
        private Image imgML;
        private Size imgSize = new Size(23, 23);
        private int img_margin = 0;
        private Image_Alignment img_algn = Image_Alignment.LeftText;
        private bool actived = false;
        private bool useActived = false;

        public btnImage() : base()
        {
            this.Size = new Size(75, 23);
            this.BgrColorMouseLeave = Color.FromArgb(40, 107, 191);
            this.Paint += btnImage_Paint;
            this.MouseDown += SimpleButton_MouseDown;
            this.MouseEnter += SimpleButton_MouseEnter;
            this.MouseLeave += SimpleButton_MouseLeave;
            this.MouseUp += SimpleButton_MouseUp;
        }

        [System.ComponentModel.Browsable(false)]
        public override Color ForeColor { get; set; }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Always),
            System.ComponentModel.Browsable(true),
            System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Invalidate();
            }
        }

        public Color TextColorMouseDown
        {
            get
            {
                return txtclrMD;
            }

            set
            {
                txtclrMD = value;
            }
        }

        public Color TextColorMouseEnter
        {
            get
            {
                return txtclrME;
            }

            set
            {
                txtclrME = value;
            }
        }

        public Color TextColorMouseLeave
        {
            get
            {
                return txtclrML;
            }

            set
            {
                txtclrML = value;
                this.txtclr = txtclrML;
                Invalidate();
            }
        }

        public Color BgrColorMouseDown
        {
            get
            {
                return bgrclrMD;
            }

            set
            {
                bgrclrMD = value;
            }
        }

        public Color BgrColorMouseEnter
        {
            get
            {
                return bgrclrME;
            }

            set
            {
                bgrclrME = value;
            }
        }

        public Color BgrColorMouseLeave
        {
            get
            {
                return bgrclrML;
            }

            set
            {
                bgrclrML = value;
                this.BackColor = bgrclrML;
            }
        }

        public Image ImageMouseDown
        {
            get
            {
                return imgMD;
            }

            set
            {
                imgMD = value;
            }
        }

        public Image ImageMouseEnter
        {
            get
            {
                return imgME;
            }

            set
            {
                imgME = value;
            }
        }

        public Image ImageMouseLeave
        {
            get { return imgML; }
            set { imgML = value; img = imgML; Invalidate(); }
        }

        public int ImgMargin
        {
            get { return img_margin; }
            set { img_margin = value; Invalidate(); }
        }

        public Size ImgSize
        {
            get { return imgSize; }
            set { imgSize = value; Invalidate(); }
        }

        public StringAlignment TextAlignment
        {
            get { return txt_algn; }
            set { txt_algn = value; Invalidate(); }
        }

        public Image_Alignment ImageAlignment
        {
            get { return img_algn; }
            set { img_algn = value; Invalidate(); }
        }

        public bool Actived
        {
            set
            {
                if (value)
                {
                    foreach (Control ctrl in this.Parent.Controls)
                    {
                        btnImage bt = ctrl as btnImage;
                        if (bt != null && bt.actived) bt.Actived = false;
                    }
                    this.actived = value;
                    if (useActived)
                    {
                        if (imgMD != null) img = imgMD;
                        if (txtclrMD != Color.Empty) txtclr = txtclrMD;
                        this.BackColor = bgrclrMD;
                        Invalidate();
                    }
                }
                else
                {
                    this.actived = value;
                    img = imgML;
                    txtclr = txtclrML;
                    this.BackColor = bgrclrML;
                    Invalidate();
                }
            }
        }

        public bool UseActived
        {
            get
            {
                return useActived;
            }

            set
            {
                useActived = value;
                if (useActived)
                {
                    actived = false;
                    this.BackColor = bgrclrML;
                }
            }
        }

        private void btnImage_Paint(object sender, PaintEventArgs e)
        {
            using (StringFormat strFM = new StringFormat())
            {
                strFM.Alignment = TextAlignment;
                strFM.LineAlignment = StringAlignment.Center;
                if (img != null)
                {
                    switch (ImageAlignment)
                    {
                        case Image_Alignment.LeftText:
                            e.Graphics.DrawImage(img, ImgMargin, (this.Height - imgSize.Height) / 2, imgSize.Width, imgSize.Height);
                            e.Graphics.DrawString(Text, this.Font, new SolidBrush(txtclr),
                                new Rectangle(ImgMargin + imgSize.Width, 0, this.Width - ImgMargin - imgSize.Width, this.Height), strFM);
                            break;
                        case Image_Alignment.RightText:
                            e.Graphics.DrawImage(img, this.Width - ImgMargin, (this.Height - imgSize.Height) / 2, imgSize.Width, imgSize.Height);
                            e.Graphics.DrawString(Text, this.Font, new SolidBrush(txtclr),
                                new Rectangle(0, 0, this.Width - ImgMargin - imgSize.Width, this.Height), strFM);
                            break;
                    }
                }
                else
                {
                    e.Graphics.DrawString(Text, this.Font, new SolidBrush(txtclr),
                    new RectangleF(0, 0, this.Width, this.Height), strFM);
                }
            }
        }

        private void SimpleButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!useActived || !actived)
            {
                if (e.X >= 0 && e.X < this.Width && e.Y >= 0 && e.Y < this.Height)
                {
                    if (imgME != null) img = imgME;
                    if (txtclrME != Color.Empty) txtclr = txtclrME;
                    this.BackColor = bgrclrME;
                    Invalidate();
                }
                else
                {
                    img = imgML;
                    txtclr = txtclrML;
                    this.BackColor = bgrclrML;
                    Invalidate();
                }
            }
        }

        private void SimpleButton_MouseLeave(object sender, System.EventArgs e)
        {
            if (!useActived || !actived)
            {
                img = imgML;
                txtclr = txtclrML;
                this.BackColor = bgrclrML;
                Invalidate();
            }
        }

        private void SimpleButton_MouseEnter(object sender, System.EventArgs e)
        {
            if (!useActived || !actived)
            {
                if (imgME != null) img = imgME;
                if (txtclrME != Color.Empty) txtclr = txtclrME;
                this.BackColor = bgrclrME;
                Invalidate();
            }
        }

        private void SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!useActived || !actived)
                {
                    if (imgMD != null) img = imgMD;
                    if (txtclrMD != Color.Empty) txtclr = txtclrMD;
                    this.BackColor = bgrclrMD;
                    Invalidate();
                }
            }
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (useActived)
            {
                if (!actived)
                {
                    this.Actived = true;
                    base.OnMouseClick(e);
                }
            }
            else base.OnMouseClick(e);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Refresh();
        }

        protected override void OnLocationChanged(EventArgs e)
        {
            this.Refresh();
        }
    }
}
