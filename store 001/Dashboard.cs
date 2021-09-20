using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace store_001
{
    public partial class Dashboard : Form
    {
      
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            radioButtonDate.Checked = true;
            DTP.Focus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

       

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked == true)
            {
                //DTP.Visible = true;
                //cmbYear.Visible = false;
                //cmbMonth.Visible = false;
                lblEnter.Text = "Pick the Date";


                DTP.CustomFormat = "dd MMM yyyy"; // this line gives you only the month and year.
                DTP.ShowUpDown = false;
                DTP.Focus();
                lblEnteredSDate.Text = DTP.Text;
                
            }
        }

        private void radioButtonMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonth.Checked == true)
            {
                //DTP.Visible = false;
                //cmbYear.Visible = true;
                //cmbMonth.Visible = true;
                lblEnter.Text = "Pick the Month";

                DTP.CustomFormat = "MMM yyyy"; // this line gives you only the month and year.
                DTP.ShowUpDown = true;
                DTP.Focus();
                lblEnteredSDate.Text = DTP.Text;
            }
        }

        private void radioButtonYear_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYear.Checked == true)
            {
                //DTP.Visible = false;
                //cmbYear.Visible = true;
                //cmbMonth.Visible = false;
                lblEnter.Text = "Pick the Year";

                DTP.CustomFormat = "yyyy"; // this line gives you only the month and year.
                DTP.ShowUpDown = true;
                DTP.Focus();
                lblEnteredSDate.Text = DTP.Text;
            }
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked == true)
            {
                lblEnteredSDate.Text = DTP.Text;
            }
            else if (radioButtonMonth.Checked == true)
            {
                lblEnteredSDate.Text = DTP.Text.ToString();
            }
            else if (radioButtonYear.Checked == true)
            {
                lblEnteredSDate.Text = DTP.Text;
            }
        }
        /// <summary>
        /// Desplay calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblEnteredSDate_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonDate.Checked == true)
            {
                lblProfit.Text = "Rs. " + My_Report.Profit(DTP.Value, 0).ToString();
                lblBillCount.Text = My_Report.GetBillCount(DTP.Value,0).ToString();
                lblProdCount.Text = My_Report.GetProductCount(DTP.Value, 0).ToString();
                lblCatCount.Text = My_Report.GetCategoryCount(DTP.Value, 0).ToString();

                My_Report.Indicator(DTP.Value, 0, lblProfitIND, lblBillIND, lblProdIND, lblCatIND, lblProfitPercent, lblBillPercent, lblProductsPercent, lblCategoryPercent);

                
            }
            if (radioButtonMonth.Checked == true)
            {
                lblProfit.Text = "Rs. " + My_Report.Profit(DTP.Value, 1).ToString();
                lblBillCount.Text = My_Report.GetBillCount(DTP.Value,1).ToString();
                lblProdCount.Text = My_Report.GetProductCount(DTP.Value, 1).ToString();
                lblCatCount.Text = My_Report.GetCategoryCount(DTP.Value, 1).ToString();

                My_Report.Indicator(DTP.Value, 1, lblProfitIND, lblBillIND, lblProdIND, lblCatIND, lblProfitPercent, lblBillPercent, lblProductsPercent, lblCategoryPercent);

            }
            if (radioButtonYear.Checked == true)
            {
                lblProfit.Text = "Rs. " + My_Report.Profit(DTP.Value, 2).ToString();
                lblBillCount.Text = My_Report.GetBillCount(DTP.Value,2).ToString();
                lblProdCount.Text = My_Report.GetProductCount(DTP.Value, 2).ToString();
                lblCatCount.Text = My_Report.GetCategoryCount(DTP.Value, 2).ToString();

                My_Report.Indicator(DTP.Value, 2, lblProfitIND, lblBillIND, lblProdIND, lblCatIND, lblProfitPercent, lblBillPercent, lblProductsPercent, lblCategoryPercent);

            }
        }

        private void btnBarcodes_Click(object sender, EventArgs e)
        {
            new BarcodeGenarator().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            INVENTORY inventory = new INVENTORY();
            inventory.Show();
        }

        private void btnBillDetails_Click(object sender, EventArgs e)
        {
            new Bill_Data().Show();
        }



        Boolean Dragable;
        int mouseX;
        int mouseY;
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {

            Dragable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            Dragable = false;
        }


        private void btnViewMoreProfit_Click(object sender, EventArgs e)
        {
            label1.Text = "Please wait ! It May take while.....";
            int selection = 0;
            if (radioButtonDate.Checked == true)
            {
                selection = 0;
            }
            if (radioButtonMonth.Checked == true)
            {
                selection = 1;
            }
            if (radioButtonYear.Checked == true)
            {
                selection = 2;
            }


            ViewMoreProfit obj = new ViewMoreProfit();

            //obj.FillPrevious();
            //obj.FillNext();
            obj.SetData(selection, DTP.Value, lblProfit.Text, lblBillCount.Text, lblCatCount.Text, lblProdCount.Text);

            
            obj.Show();


        }

        private void btnViewMoreBillProdCat_Click(object sender, EventArgs e)
        {
            ViewMoreBillProdCat obj = new ViewMoreBillProdCat();
            if(radioButtonDate.Checked==true)
            {
                obj.Setdata(DTP.Value, 0);
            }
            else if (radioButtonMonth.Checked == true)
            {
                obj.Setdata(DTP.Value, 1);
            }
            else if (radioButtonYear.Checked == true)
            {
                obj.Setdata(DTP.Value, 2);
            }
            obj.Show();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label1.Text== "Bills........")
            {
                label1.Text = "Bills";
            }
            else
            {
                label1.Text = label1.Text + ".";
            }
            timer1.Interval = 500;
        }
    }
}
