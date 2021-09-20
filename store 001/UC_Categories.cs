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
    public partial class UC_Categories : UserControl
    {
        public UC_Categories()
        {
            InitializeComponent();
        }


        int radio = -1;




        public void settable(DateTime SelectedDate, int SelectedRadio)
        {
            lbldate.Text = SelectedDate.ToShortDateString();
            radio = SelectedRadio;

            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();

            string Where_Clause = "";

            if (SelectedRadio == 0)
            {

                Where_Clause = "WHERE BILL_DATE = '" + SelectedDate + "'";

            }

            else if (SelectedRadio == 1)
            {

                Where_Clause = "WHERE MONTH(BILL_DETAILS.BILL_DATE) =" + SelectedDate.Month + " AND YEAR(BILL_DETAILS.BILL_DATE)=" + SelectedDate.Year + "";

            }

            else if (SelectedRadio == 2)
            {

                Where_Clause = "WHERE YEAR(BILL_DETAILS.BILL_DATE)= " + SelectedDate.Year + "";

            }
            DataTable DT = new DataTable();
            string SQL1 = @"SELECT INVENTORY.CATEGORY , COUNT(*)   FROM ((SOLD_OUT INNER JOIN INVENTORY ON SOLD_OUT.PRODUCT_ID=INVENTORY.PRODUCT_ID) INNER JOIN BILL_DETAILS ON BILL_DETAILS.BILL_ID=SOLD_OUT.BILL_ID )  " + Where_Clause + " GROUP BY INVENTORY.CATEGORY";
            SqlCommand com1 = new SqlCommand(SQL1, con);
            SqlDataReader reader = com1.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (DT.Rows.Count == 0)
                    {

                        DataColumn dc01 = new DataColumn("Category", typeof(string));
                        DataColumn dc02 = new DataColumn("quantity", typeof(string));

                        if (!DT.Columns.Contains("Category"))
                        {
                            DT.Columns.Add(dc01);
                        }
                        if (!DT.Columns.Contains("quantity"))
                        {
                            DT.Columns.Add(dc02);
                        }



                        DT.Rows.Add(reader.GetString(0), reader.GetInt32(1).ToString());

                    }
                    else
                    {
                        DT.Rows.Add(reader.GetString(0), reader.GetInt32(1).ToString());
                    }
                }
            }
            dgCategories.DataSource = DT;
            reader.Close();
            con.Close();
        }

       

        private void UC_Categories_Load(object sender, EventArgs e)
        {

        }

        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {



                DataGridViewRow gridViewRow = dgCategories.Rows[e.RowIndex];


                lblCategory.Text = gridViewRow.Cells[0].Value.ToString();
                dgProductsofCategory.DataSource = My_Report.GetSource(Convert.ToDateTime(lbldate.Text), lblCategory.Text, radio);

                lblProfit.Text = My_Report.Profit(Convert.ToDateTime(lbldate.Text), lblCategory.Text, radio).ToString();

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
