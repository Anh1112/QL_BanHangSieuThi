using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Class
{
    class txtboxSearch : TextBox
    {
        // private string defaultstring = "Search...";
        private string defaultstring;
        public String DefaultString
        {
            get { return defaultstring; }
            set { defaultstring = value; Invalidate(); }
        }

        public event EventHandler EventKeyEnter;
        public txtboxSearch() : base()
        {
            this.BorderStyle = BorderStyle.None;
            this.Text = defaultstring;
            this.TabStop = false;
            this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Italic);
            this.ForeColor = System.Drawing.Color.DimGray;

        }
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (this.Text == null || this.Text.Trim() == "")
            {
                this.Text = defaultstring;
                this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Italic);
                this.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (this.Text == defaultstring)
            {
                this.Text = "";
                this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size, System.Drawing.FontStyle.Regular);
                this.ForeColor = System.Drawing.Color.Black;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                EventKeyEnter?.Invoke(this, EventArgs.Empty);
                return;
            }
            base.OnKeyDown(e);
        }
    }
}
