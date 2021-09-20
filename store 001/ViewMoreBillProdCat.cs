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
    public partial class ViewMoreBillProdCat : Form
    {
        public ViewMoreBillProdCat()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        DateTime Date;
        int Radio;

        private void ViewMoreBillProdCat_Load(object sender, EventArgs e)
        {
            uC_Categories1.Visible = false;
            uC_Bills1.Visible = true;
            btnProducts.PerformClick();
        }

        public void Setdata(DateTime SelectedDate,int SelectedRadio)
        {
            Date = SelectedDate;
            Radio = SelectedRadio;
           
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            btnBills.BackColor = Color.Black;
            btncategories.BackColor = Color.FromArgb(0, 40, 82);
            btnProducts.BackColor = Color.FromArgb(0, 40, 82);


            uC_Bills1.SetBills(Date, Radio);
            uC_Bills1.Visible = true;
            uC_Categories1.Visible = false;
            uC_Products1.Visible = false;
           
        }

        private void btncategories_Click(object sender, EventArgs e)
        {

            btnBills.BackColor = Color.FromArgb(0, 40, 82);
            btncategories.BackColor = Color.Black;
            btnProducts.BackColor = Color.FromArgb(0, 40, 82);

            uC_Bills1.Visible = false;
            uC_Categories1.Visible = true;
            uC_Products1.Visible = false;
            uC_Categories1.settable(Date, Radio);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            btnBills.BackColor = Color.FromArgb(0, 40, 82);
            btncategories.BackColor = Color.FromArgb(0, 40, 82);
            btnProducts.BackColor = Color.Black;

            uC_Bills1.Visible = false;
            uC_Categories1.Visible = false;
            uC_Products1.Visible = true;
            uC_Products1.setdata(Date, Radio);
        }

        private void uC_Products1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Bills1_Load(object sender, EventArgs e)
        {

        }
    }
}
