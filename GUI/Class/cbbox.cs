using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Class
{
    class cbbox : ComboBox
    {
        protected override void OnKeyDown(KeyEventArgs e) { e.Handled = true; }
        protected override void OnKeyPress(KeyPressEventArgs e) { e.Handled = true; }
        protected override void OnKeyUp(KeyEventArgs e) { e.Handled = true; }
        protected override void OnSelectedValueChanged(EventArgs e)
        {
            base.OnSelectedValueChanged(e);
            this.Parent.Select();
        }
    }
}
