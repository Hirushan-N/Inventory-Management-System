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
    public partial class UC_Products : UserControl
    {
        public UC_Products()
        {
            InitializeComponent();
        }
        DateTime Date;
        int Radio;
        public void setdata(DateTime SelectedDate,int SelectedRadio)
        {
            Date = SelectedDate;
            lbldate.Text = SelectedDate.ToShortDateString();
            Radio = SelectedRadio;
            dgProducts.DataSource = My_Report.GetSource(SelectedDate, SelectedRadio);
        }

        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblProduct.Text = dgProducts.SelectedCells[1].Value.ToString();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"SELECT * FROM INVENTORY WHERE PRODUCT_NAME='" + lblProduct.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lblProductID.Text = reader.GetInt32(0).ToString();
                        lblQuantity.Text = reader.GetDecimal(2).ToString();
                        lblCategory.Text = reader.GetString(3);
                        lblWholeSale.Text = reader.GetDecimal(5).ToString();
                        lblUnitPrice.Text = reader.GetDecimal(6).ToString();
                    }
                }

                lblProfit.Text = My_Report.Profit(Date, lblProduct, Radio).ToString();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UC_Products_Load(object sender, EventArgs e)
        {

        }
    }
}
