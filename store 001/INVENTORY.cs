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
    public partial class INVENTORY : Form
    {
        public INVENTORY()
        {
            InitializeComponent();
            Costomizing();
        }
        
        private void Navigator_Load(object sender, EventArgs e)
        {
            


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
        }
        



        private void Costomizing()
        {
            ucViewCategory1.Visible = false;
            ucViewProduct1.Visible = false;
            DGViewAll.Visible = false;
            DGViewAll.Visible = false;
            panel10.Visible = false;
            panel9.Visible = false;
            panel5.Visible = false;
        }

        private void hidesubmenu()
        {
            if (panel10.Visible == true)
                panel10.Visible = false;
            if (panel9.Visible == true)
                panel9.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            
        }
        
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible==false)
            {
                //hidesubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
   

        private void button24_Click(object sender, EventArgs e)
        {
            showsubmenu(panel10);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            showsubmenu(panel10);
            showsubmenu(panel9);
            showsubmenu(panel1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showsubmenu(panel1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestoreDown_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnRestoreDown.Text = "2";
            }
            else if (this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnRestoreDown.Text = "1";
            }
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
        private void HeadingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Dragable = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void HeadingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(Dragable)
            {
                this.Top = Cursor.Position.Y - mouseY;
                this.Left = Cursor.Position.X - mouseX;
            }
        }

        private void HeadingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Dragable = false;
        }



        private void Reports_Click(object sender, EventArgs e)
        {

            showsubmenu(panel1);
        }


        private void btnMenuView_Click(object sender, EventArgs e)
        {
            showsubmenu(panel10);

        }

        private void btnMenuEdit_Click(object sender, EventArgs e)
        {

            showsubmenu(panel9);

        }


        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ucViewCategory1.Visible = false;
            ucViewProduct1.Visible = false;
            DGViewAll.Visible = true;

            DGViewAll.Rows.Clear();

            if(this.WindowState == FormWindowState.Normal)
            {
                DGViewAll.DefaultCellStyle.Font=new Font("Microsoft Sans Serif", 8);
            }

            try
            {

                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"SELECT * FROM INVENTORY ORDER BY PRODUCT_ID ASC";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        DGViewAll.Rows.Add(
                            new object[]
                            {
                                reader.GetInt32(0),reader.GetString(1),reader.GetDecimal(2),reader.GetString(3),reader.GetDateTime(4).ToShortDateString(),reader.GetDecimal(5),reader.GetDecimal(6)
                            }
                            ); 
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            ucViewCategory1.Visible = false;
            ucViewProduct1.Visible = true;
            DGViewAll.Visible = false;
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            ucViewCategory1.Visible = true;
            ucViewProduct1.Visible = false;
            DGViewAll.Visible = false;
        }

        //wanted
        private void btnMenuView_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel10);
        }

        private void btnMenuEdit_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panel9);
           
        }

        private void btnmenuReports_Click(object sender, EventArgs e)
        {
            showsubmenu(panel5);
            panel2.Focus();
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            UDDialog ud = new UDDialog();
            ud.getstyle(0);
            ud.Show();
        }

      

        private void BtnEditAdd_Click(object sender, EventArgs e)
        {
            AddNew add = new AddNew();
            add.Show();
        }

        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            UDDialog ud = new UDDialog();
            ud.getstyle(1);
            ud.Show();
        }

        private void DGViewAll_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right && DGViewAll.CurrentRow.Selected==true)
            {
                DataGridViewRow viwerow = DGViewAll.Rows[DGViewAll.SelectedRows[0].Index];
                veriablee.id = viwerow.Cells[0].Value.ToString();

                veriablee.name = viwerow.Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show("Are you want to edit this record "+"'"+veriablee.name+"'"+" ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    
                    veriablee.quantity = viwerow.Cells[2].Value.ToString();
                    veriablee.catogoty = viwerow.Cells[3].Value.ToString();
                    veriablee.date = Convert.ToDateTime(viwerow.Cells[4].Value);
                    veriablee.unit = viwerow.Cells[5].Value.ToString();
                    UDDialog ud = new UDDialog();
                    ud.getstyle(2);
                    ud.Show();
                    

                    
                }
            }
        }

       
    }
}
