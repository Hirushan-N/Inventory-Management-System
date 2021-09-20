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
    public partial class UCViewCategory : UserControl
    {
        public UCViewCategory()
        {
            InitializeComponent();
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            DGViewCategory.BorderStyle = BorderStyle.None;
            DGViewCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            DGViewCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGViewCategory.DefaultCellStyle.SelectionBackColor = Color.Blue;
            DGViewCategory.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            DGViewCategory.BackgroundColor = Color.FromArgb(30, 30, 30);
            DGViewCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGViewCategory.EnableHeadersVisualStyles = false;
            DGViewCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGViewCategory.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            DGViewCategory.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            DGViewCategory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            try
            {
                SqlConnection con = new SqlConnection(connectDB.connectionstring);
                con.Open();
                string sql = @"SELECT * FROM INVENTORY WHERE CATEGORY='" + cmbCategory.Text + "'";
                SqlDataAdapter objectadp = new SqlDataAdapter(sql, con);
                DataTable tbobject = new DataTable();
                objectadp.Fill(tbobject);
                DGViewCategory.DataSource = tbobject;
                con.Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void UCViewCategory_Load(object sender, EventArgs e)
        {
            
            My_AutoCompleate.Categories(cmbCategory);
        }

        private void DGViewCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && DGViewCategory.SelectedRows.Count == 1)
            {

                DataGridViewRow viwerow = DGViewCategory.Rows[DGViewCategory.SelectedRows[0].Index];
                veriablee.id = viwerow.Cells[0].Value.ToString();
                veriablee.name = viwerow.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show("Are you want to update this record " + "'" + veriablee.name + "'" + " ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
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
