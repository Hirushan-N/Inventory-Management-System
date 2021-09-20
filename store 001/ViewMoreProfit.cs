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
    public partial class ViewMoreProfit : Form
    {
        int SelectedRadio = 0;
        DateTime SelectedDate;
        public ViewMoreProfit()
        {
            InitializeComponent();
        }

        public void SetData(int SelectedRadio, DateTime SelectedDate, string Profit, string Bills, String Categories, string Products)
        {
            this.SelectedRadio = SelectedRadio;
            if (SelectedRadio == 0)
            {
                lblHead.Text = "Date";
            }
            else if (SelectedRadio == 1)
            {
                lblHead.Text = "Month";
            }
            else if (SelectedRadio == 2)
            {
                lblHead.Text = "Year";
            }

            lblPeriod.Text = SelectedDate.ToShortDateString();
            lblProfit.Text = Profit;
            lblBills.Text = Bills;
            lblCategories.Text = Categories;
            lblProducts.Text = Products;
            this.SelectedDate = SelectedDate;
            FillPrevious();
            FillNext();
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

        private void ViewMoreProfit_Load(object sender, EventArgs e)
        {
            //FillPrevious(Convert.ToDateTime(lblPeriod.Text), filter);
            //FillNext(Convert.ToDateTime(lblPeriod.Text), filter);
        }

        public void FillPrevious()
        {
            DataTable DT = new DataTable();

            for (int i=30;i>0;i--)
            {
                DateTime date = SelectedDate.AddDays(-i);

               

                if (DT.Rows.Count == 0)
                {

                    DataColumn dc01 = new DataColumn("Date", typeof(string));
                    DataColumn dc02 = new DataColumn("Profit", typeof(string));
                    DataColumn dc04 = new DataColumn("Bills", typeof(string));
                    DataColumn dc05 = new DataColumn("Categories", typeof(string));
                    DataColumn dc06 = new DataColumn("Product", typeof(string));


                    if (!DT.Columns.Contains("Date"))
                    {
                        DT.Columns.Add(dc01);
                    }
                    if (!DT.Columns.Contains("Profit"))
                    {
                        DT.Columns.Add(dc02);
                    }
                    if (!DT.Columns.Contains("Bills"))
                    {
                        DT.Columns.Add(dc04);
                    }
                    if (!DT.Columns.Contains("Categories"))
                    {
                        DT.Columns.Add(dc05);
                    }
                    if (!DT.Columns.Contains("Product"))
                    {
                        DT.Columns.Add(dc06);
                    }

                    DT.Rows.Add(date.ToShortDateString(), "Rs." + My_Report.Profit(date, SelectedRadio).ToString(), My_Report.GetBillCount(date, SelectedRadio), My_Report.GetCategoryCount(date, SelectedRadio), My_Report.GetProductCount(date, SelectedRadio));

                }
                else
                {
                    DT.Rows.Add(date.ToShortDateString(), "Rs." + My_Report.Profit(date, SelectedRadio).ToString(), My_Report.GetBillCount(date, SelectedRadio), My_Report.GetCategoryCount(date, SelectedRadio), My_Report.GetProductCount(date, SelectedRadio));

                }


                //dgPrevious.Rows.Add
                //            (
                //            new object[]
                //            {
                //                date.ToShortDateString(),"Rs."+My_Report.Profit(date,FilterMode).ToString(),My_Report.GetBillCount(date,FilterMode),My_Report.GetCategoryCount(date,FilterMode),My_Report.GetProductCount(date,FilterMode)
                //            }
                //            ); ;
            }
            dgPrevious.DataSource = DT;
 


        }

        public void FillNext()
        {
            DataTable DT = new DataTable();

            for (int i = 1; i<31; i++)
            {
                DateTime date = SelectedDate.AddDays(i);

                if (DT.Rows.Count == 0)
                {

                    DataColumn dc01 = new DataColumn("Date", typeof(string));
                    DataColumn dc02 = new DataColumn("Profit", typeof(string));
                    DataColumn dc04 = new DataColumn("Bills", typeof(string));
                    DataColumn dc05 = new DataColumn("Categories", typeof(string));
                    DataColumn dc06 = new DataColumn("Product", typeof(string));


                    if (!DT.Columns.Contains("Date"))
                    {
                        DT.Columns.Add(dc01);
                    }
                    if (!DT.Columns.Contains("Profit"))
                    {
                        DT.Columns.Add(dc02);
                    }
                    if (!DT.Columns.Contains("Bills"))
                    {
                        DT.Columns.Add(dc04);
                    }
                    if (!DT.Columns.Contains("Categories"))
                    {
                        DT.Columns.Add(dc05);
                    }
                    if (!DT.Columns.Contains("Product"))
                    {
                        DT.Columns.Add(dc06);
                    }

                    DT.Rows.Add(date.ToShortDateString(), "Rs." + My_Report.Profit(date, SelectedRadio).ToString(), My_Report.GetBillCount(date, SelectedRadio), My_Report.GetCategoryCount(date, SelectedRadio), My_Report.GetProductCount(date, SelectedRadio));

                }
                else
                {
                    DT.Rows.Add(date.ToShortDateString(), "Rs." + My_Report.Profit(date, SelectedRadio).ToString(), My_Report.GetBillCount(date, SelectedRadio), My_Report.GetCategoryCount(date, SelectedRadio), My_Report.GetProductCount(date, SelectedRadio));

                }


                //dgNext.Rows.Add
                //            (
                //            new object[]
                //            {
                //                date.ToShortDateString(),"Rs."+My_Report.Profit(date,FilterMode).ToString(),My_Report.GetBillCount(date,FilterMode),My_Report.GetCategoryCount(date,FilterMode),My_Report.GetProductCount(date,FilterMode)
                //            }
                //            ); ;
            }
            dgNext.DataSource = DT;



        }
        Boolean Dragable;
        int mouseX;
        int mouseY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragable = false;
        }
    }
}
