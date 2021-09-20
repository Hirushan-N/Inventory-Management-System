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
    public partial class UC_Bills : UserControl
    {
        public UC_Bills()
        {
            InitializeComponent();
        }

        private void UC_Bills_Load(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        public void SetBills(DateTime SelectedDate,int SelectodRadio)
        {
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();

            string WhereClause="";

            if(SelectodRadio==0)
            {
                WhereClause= "WHERE BILL_DATE = '"+SelectedDate+"'";
            }
            else if (SelectodRadio == 1)
            {
                WhereClause = "WHERE  MONTH(BILL_DATE)="+SelectedDate.Month+ "AND YEAR(BILL_DATE)="+SelectedDate.Year+"";
            }
            else if (SelectodRadio == 2)
            {
                WhereClause = "WHERE  YEAR(BILL_DATE)=" + SelectedDate.Year + "";
            }

            string sql = @"SELECT * FROM BILL_DETAILS "+WhereClause+" ORDER BY BILL_ID ASC ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable DT = new DataTable();
            if (reader.HasRows)
            {
               

                while (reader.Read())
                {
                    if (DT.Rows.Count == 0)
                    {

                        DataColumn dc01 = new DataColumn("Product Id", typeof(string));
                        DataColumn dc02 = new DataColumn("Product Name", typeof(string));
                        DataColumn dc03 = new DataColumn("Unit Price", typeof(string));

                        if (!DT.Columns.Contains("Product Id"))
                        {
                            DT.Columns.Add(dc01);
                        }
                        if (!DT.Columns.Contains("Product Name"))
                        {
                            DT.Columns.Add(dc02);
                        }
                        if (!DT.Columns.Contains("Unit Price"))
                        {
                            DT.Columns.Add(dc03);
                        }
                        

                        DT.Rows.Add(reader.GetString(0), reader.GetDateTime(1).ToShortDateString(), reader.GetDecimal(2));

                    }
                    else
                    {
                        DT.Rows.Add(reader.GetString(0), reader.GetDateTime(1).ToShortDateString(), reader.GetDecimal(2));
                    }
                }
            }
            dgBills.DataSource = DT;
        }
       
        
        private void dgBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            if (e.RowIndex >= 0)
            {
                


                DataGridViewRow gridViewRow = dgBills.Rows[e.RowIndex];



                lblID.Text = gridViewRow.Cells[0].Value.ToString();
                lbldate.Text = gridViewRow.Cells[1].Value.ToString();
                lblBillAmount.Text = gridViewRow.Cells[2].Value.ToString();


                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();

                DataTable DT = new DataTable();

                string sql = @"SELECT  INVENTORY.PRODUCT_NAME , INVENTORY.RETAIL_PRICE , SOLD_OUT.SOLD_QUANTITY , SOLD_OUT.TOTAL_AMOUNT    FROM SOLD_OUT INNER JOIN INVENTORY ON SOLD_OUT.PRODUCT_ID=INVENTORY.PRODUCT_ID WHERE SOLD_OUT.BILL_ID='" + lblID.Text + "'";
                SqlCommand command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                   

                    while (reader.Read())
                    {
                        if (DT.Rows.Count == 0)
                        {
                            DataColumn dc01 = new DataColumn("Product name", typeof(string));
                            DataColumn dc02 = new DataColumn("Unit Price", typeof(string));
                            DataColumn dc03 = new DataColumn("Quantity", typeof(string));
                            DataColumn dc04 = new DataColumn("Net price", typeof(string));


                            if (!DT.Columns.Contains("Product name"))
                            {
                                DT.Columns.Add(dc01);
                            }
                            if (!DT.Columns.Contains("Unit Price"))
                            {
                                DT.Columns.Add(dc02);
                            }
                            if (!DT.Columns.Contains("Quantity"))
                            {
                                DT.Columns.Add(dc03);
                            }
                            if (!DT.Columns.Contains("Net price"))
                            {
                                DT.Columns.Add(dc04);
                            }


                            DT.Rows.Add(reader.GetString(0), reader.GetDecimal(1).ToString(), reader.GetDecimal(2).ToString(), reader.GetDecimal(3).ToString());

                        }
                        else
                        {
                            DT.Rows.Add(reader.GetString(0), reader.GetDecimal(1).ToString(), reader.GetDecimal(2).ToString(), reader.GetDecimal(3).ToString());
                        }
                    }
                   

                   
                }
                dgBillData.DataSource = DT;


            }
        }
    }
}
