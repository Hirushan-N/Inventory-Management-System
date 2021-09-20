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
    public partial class UDDialog : Form
    {


        public UDDialog()
        {
            InitializeComponent();
        }


        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();

                string sql = @"UPDATE INVENTORY SET QUANTITY='" + txt_quantity.Text + "',ENTERED_DATE= '" + dtp_date.Value + "',UNIT_PRICE='" + txt_unitprice.Text + "'WHERE PRODUCT_ID='" + txtProId.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.UpdateCommand = new SqlCommand(sql, con);
                sda.UpdateCommand.ExecuteNonQuery();

                txt_name.AutoCompleteCustomSource = My_AutoCompleate.ProductName();

                MessageBox.Show("sucsessfull updated... :) ");
                con.Close();

                txt_name.Text = "";
                txtProId.Text = "";
                txt_quantity.Text = "";
                txt_unitprice.Text = "";
                cmb_catogory.Text = "";
                dtp_date.Text = "";



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        private void upd_Load(object sender, EventArgs e)
        {
            My_AutoCompleate.Categories(cmb_catogory);
            My_AutoCompleate.Categories(cmbExtCategory);
            if (style == 0)
            {
                butProductelete.Visible = false;
                catDelete.Visible = false;
                lblUd.Text = "Update";
            }
            else if(style==1)
            {
                butProductUpdate.Visible = false;
                CatUpdate.Visible = false;
                lblUd.Text = "Delete";

            }
            else if(style==2)
            {
                lblUd.Text = "Update Or Delete";
                panelUDCategory.Visible = false;
                btncategory.Visible = false;
                btnproduct.Visible = false;
                txtProId.Text = veriablee.id;
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();

                string sql = @"SELECT * FROM INVENTORY WHERE PRODUCT_ID='" + txtProId.Text + "'";
                SqlCommand objectcom = new SqlCommand(sql, con);

                SqlDataReader reader = objectcom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_name.Text = reader.GetString(1);
                        txt_quantity.Text = reader.GetDecimal(2).ToString();
                        cmb_catogory.Text = reader.GetString(3);
                        dtp_date.Value = reader.GetDateTime(4);
                        txt_pricetaken.Text = reader.GetDecimal(5).ToString();
                        txt_unitprice.Text = reader.GetDecimal(6).ToString();
                    }
                }
                con.Close();
            }
                


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;

            txt_name.AutoCompleteCustomSource = My_AutoCompleate.ProductName();


            
            
        }
       
      


        private void txt_name_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();
            string sql = @"SELECT * FROM INVENTORY WHERE product_name= '" + txt_name.Text + "'";
            SqlCommand objectcom = new SqlCommand(sql, con);

            SqlDataReader reder = objectcom.ExecuteReader();
            if (reder.HasRows)
            {
                while (reder.Read())
                {
                    txtProId.Text = reder.GetString(0);
                    txt_unitprice.Text = reder.GetDecimal(5).ToString();
                    txt_quantity.Text = reder.GetInt32(2).ToString();
                    cmb_catogory.Text = reder.GetString(3);

                }
            }
            else
            {
                MessageBox.Show("invalide input");
            }
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this", "message", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"DELETE FROM INVENTORY WHERE product_name='" + txt_name.Text + "'";
                SqlDataAdapter ADP = new SqlDataAdapter();
                ADP.DeleteCommand = new SqlCommand(sql, con);
                ADP.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("sucsessfull deleted");
                con.Close();

                txt_name.Text = "";
                txtProId.Text = "";
                txt_quantity.Text = "";
                txt_unitprice.Text = "";
                cmb_catogory.Text = "";
                dtp_date.Text = "";

                txt_name.AutoCompleteCustomSource = My_AutoCompleate.ProductName();
            }
           

        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            panelUDProduct.Visible = true;
            panelUDCategory.Visible = false;
            btncategory.BackColor = Color.FromArgb(64, 100, 134);
            btnproduct.BackColor = Color.FromArgb(0, 40, 82);

        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            panelUDCategory.Visible = true;
            panelUDProduct.Visible = false;
            btnproduct.BackColor = Color.FromArgb(64, 100, 134);
            btncategory.BackColor = Color.FromArgb(0, 40, 82);
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

        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txtProId.Text = "";
            txt_quantity.Text = "";
            txt_unitprice.Text = "";
            cmb_catogory.Text = "";
            dtp_date.Text = "";
            this.Close();
            
        }

        int style=0;
        public void getstyle(int givepara)
        {
            style = givepara;
        }

        private void txtProId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();

                string sql = @"SELECT * FROM INVENTORY WHERE PRODUCT_ID='"+txtProId.Text+"'";
                SqlCommand objectcom = new SqlCommand(sql, con);

                SqlDataReader reader = objectcom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txt_name.Text = reader.GetString(1);
                        txt_quantity.Text = reader.GetDecimal(2).ToString();
                        cmb_catogory.Text = reader.GetString(3);
                        dtp_date.Value = reader.GetDateTime(4);
                        txt_pricetaken.Text = reader.GetDecimal(5).ToString();
                        txt_unitprice.Text = reader.GetDecimal(6).ToString();
                    }
                }
            }
        }
    }
    public class veriablee {

        public static  string id="";
        public static string name="";
        public static string quantity="";
        public static string catogoty="";
        public static DateTime date = DateTime.Today;
        public static string unit="";
    }                 
}
