using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Class
{
    [System.ComponentModel.DefaultEvent("MouseClick")]
    class btnSimple : UserControl
    {
        private string text;
        private StringAlignment alignment = StringAlignment.Center;
        private Color clrMD = Color.FromArgb(26, 71, 127);
        private Color clrME = Color.FromArgb(0, 122, 204);
        private Color clrML;
        private bool actived = false;
        private bool useActived = false;

        public btnSimple() : base()
        {
            this.Size = new Size(75, 23);
            this.ColorMouseLeave = Color.FromArgb(40, 107, 191);
            this.ForeColor = Color.White;
            this.Paint += btnSimple_Paint;
            this.MouseDown += btnSimple_MouseDown;
            this.MouseEnter += btnSimple_MouseEnter;
            this.MouseLeave += btnSimple_MouseLeave;
            this.MouseUp += btnSimple_MouseUp;
        }

        private void btnSimple_MouseUp(object sender, MouseEventArgs e)
        {
            if (!useActived || !actived)
            {
                if (e.X >= 0 && e.X < this.Width && e.Y >= 0 && e.Y < this.Height)
                {
                    this.BackColor = clrME;
                }
                else this.BackColor = clrML;
            }
        }

        private void btnSimple_MouseLeave(object sender, System.EventArgs e)
        {
            if (!useActived || !actived) this.BackColor = clrML;
        }

        private void btnSimple_MouseEnter(object sender, System.EventArgs e)
        {
            if (!useActived || !actived) this.BackColor = clrME;
        }

        private void btnSimple_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!useActived || !actived) this.BackColor = clrMD;
            }
        }

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

        public Color ColorMouseDown
        {
            get
            {
                return clrMD;
            }

            set
            {
                clrMD = value;
            }
        }

        public Color ColorMouseEnter
        {
            get
            {
                return clrME;
            }

            set
            {
                clrME = value;
            }
        }

        public Color ColorMouseLeave
        {
            get
            {
                return clrML;
            }

            set
            {
                clrML = value;
                this.BackColor = clrML;
            }
        }

        public StringAlignment Alignment
        {
            get
            {
                return alignment;
            }
            set
            {
                alignment = value;
                Invalidate();
            }
        }

        public bool Actived
        {
            set
            {
                if (value)
                {
                    foreach (Control ctrl in this.Parent.Controls)
                    {
                        btnSimple bt = ctrl as btnSimple;
                        if (bt != null && bt.actived) bt.Actived = false;
                    }
                    this.actived = value;
                    this.BackColor = clrMD;
                }
                else
                {
                    this.actived = value;
                    this.BackColor = clrML;
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
                    this.BackColor = clrML;
                }
            }
        }

        private void btnSimple_Paint(object sender, PaintEventArgs e)
        {
            using (StringFormat strFM = new StringFormat())
            {
                strFM.Alignment = Alignment;
                strFM.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString(Text, this.Font, new SolidBrush(this.ForeColor),
                    new RectangleF(0, 0, this.Width, this.Height), strFM);
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
