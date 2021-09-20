using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_001
{
    public partial class UC_Header : UserControl
    {
        public UC_Header()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Form form = (Form)this.Parent;
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            else if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Minimized;
            }
            else if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            Form form = (Form)this.Parent;
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
                btnRestoreDown.Text = "2";
            }
            else if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                btnRestoreDown.Text = "1";
            }
        }
    }
}
