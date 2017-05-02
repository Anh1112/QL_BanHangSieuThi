using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Class;

namespace GUI
{
    public partial class FormMain : Form
    {
        //Mouse_Position mouse_point = Mouse_Position.None;
        public FormMain()
        {
            DTO.Connect.SetConnectString(Application.StartupPath.Replace(@"bin\Debug", @"data\SieuThi.mdf"));
            while (!DTO.Connect.Open() && MessageBox.Show("Can not connect DataBase", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ;
            MessageBox.Show(DTO.Connect.GetSqlConnection().State.ToString());
            InitializeComponent();
        }
    }
}
