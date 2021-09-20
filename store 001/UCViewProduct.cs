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
    public partial class UCViewProduct : UserControl
    {
        public UCViewProduct()
        {
            InitializeComponent();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            

            try
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"SELECT * FROM INVENTORY WHERE PRODUCT_NAME='" + txtProductName.Text + "'";
                SqlCommand command = new SqlCommand (sql, con);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        lblProductID.Text = reader.GetInt32(0).ToString();
                        lblName.Text = reader.GetString(1);
                        lblQuantity.Text = reader.GetDecimal(2).ToString();
                        lblCategory.Text = reader.GetString(3);
                        lbldate.Text = reader.GetDateTime(4).ToString();
                        lblTakenprice.Text = reader.GetDecimal(5).ToString();
                        lblUnitPrice.Text = reader.GetDecimal(6).ToString();
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UCViewProduct_Load(object sender, EventArgs e)
        {
            txtProductName.AutoCompleteCustomSource = My_AutoCompleate.ProductName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to update this record " + "'" + veriablee.name + "'" + " ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                veriablee.id = lblProductID.Text;
                UDDialog ud = new UDDialog();
                ud.getstyle(2);
                ud.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this", "message", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"DELETE FROM INVENTORY WHERE PRODUCT_NAME='" + lblProductID.Text + "'";
                SqlDataAdapter ADP = new SqlDataAdapter();
                ADP.DeleteCommand = new SqlCommand(sql, con);
                ADP.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted");
                con.Close();


                txtProductName.AutoCompleteCustomSource = My_AutoCompleate.ProductName();
            }
        }
    }
}
