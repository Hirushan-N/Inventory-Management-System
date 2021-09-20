using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace store_001
{
    public partial class AddNew : Form
    {
        public AddNew()
        {
            InitializeComponent();
        }

 
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        Boolean Dragable;
        int mouseX;
        int mouseY;
        private void panelFormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Dragable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panelFormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void panelFormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            Dragable = false;
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            My_AutoCompleate.Categories(cmb_catogory);
            lblProductID.Text = My_Genarate.Product_ID();
            txt_name.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();
            try
            {
                My_InsertInto.INVENTORY(lblProductID.Text, txt_name.Text, txt_quantity.Text, cmb_catogory.Text, dtp_date.Value, txt_pricetaken.Text, txt_unitprice.Text);

                txt_name.Text = "";
                txt_quantity.Text = "";
                txt_unitprice.Text = "";
                txt_pricetaken.Text = "";
                cmb_catogory.Text = "";

                lblProductID.Text = My_Genarate.Product_ID();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_quantity.Text = "";
            txt_unitprice.Text = "";
            txt_pricetaken.Text = "";
            cmb_catogory.Text = "";
        }


        

        private void cmb_catogory_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_name.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_pricetaken.Focus();
            }
        }

        private void txt_pricetaken_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_unitprice.Focus();
            }
        }

        private void txt_unitprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_quantity.Focus();
            }
        }

        
    }
   
}
