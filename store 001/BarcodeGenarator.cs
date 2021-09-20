using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace store_001
{
    public partial class BarcodeGenarator : Form
    {
        public BarcodeGenarator()
        {
            InitializeComponent();
        }

        private void BarcodeGenarator_Load(object sender, EventArgs e)
        {
            My_AutoCompleate.Categories(cmbCategory);
            txtProductName.AutoCompleteCustomSource = My_AutoCompleate.ProductName();

            CmbGenarateMode.Text = "-Please Seelect the Genarate Mode-";
            panelGetdata.Visible = false;
            btnGenarate.Visible = false;

            lblWorning.Text = "* Pleace select the location";


            
        }

        string DirectoryName;
        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            if(txtProductName.Visible==true)
            {
                
                if(txtProductName.Text == "All Products")
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    //s.DefaultExt = ".Jpg";// Default file extension
                    //s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                    if (fbd.ShowDialog() == DialogResult.OK)
                    {

                        // Save Image
                        txtLocation.Text = fbd.SelectedPath+"\\";
                       //DirectoryName = Path.GetDirectoryName(fbd.SelectedPath);

                    }
                    fbd.Dispose();
                }
                else if(txtProductName.Text != "All Products")
                {
                    SaveFileDialog s = new SaveFileDialog();
                    s.FileName = txtFileName.Text;// Default file name
                    s.DefaultExt = ".Jpg";// Default file extension
                    s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                    if (s.ShowDialog() == DialogResult.OK)
                    {

                        // Save Image
                        txtLocation.Text = s.FileName;
                        DirectoryName = Path.GetDirectoryName(s.FileName);

                    }
                    s.Dispose();
                }
                

               
            }
            else if(cmbCategory.Visible==true)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                //s.DefaultExt = ".Jpg";// Default file extension
                //s.Filter = "Image (.jpg)|*.jpg"; // Filter files by extension

                if (fbd.ShowDialog() == DialogResult.OK)
                {

                    // Save Image
                    txtLocation.Text = fbd.SelectedPath + "\\"+txtFileName.Text;
                    DirectoryName = fbd.SelectedPath;

                }

                fbd.Dispose();
            }


           
            
        }

        private void CmbGenarateMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocation.Text = "";
            if(CmbGenarateMode.Text == "-Please Seelect the Genarate Mode-")
            {
                panelGetdata.Visible = false;
            }
            if(CmbGenarateMode.SelectedIndex==0)
            {
                panelGetdata.Visible = true;
                btnGenarate.Visible = true;

                lblProductorCategory.Text = "Select Category / Product";
                lblFileorFolder.Text = "Folder Name";
                cmbCategory.Visible = false;
                txtProductName.Visible = true;


                txtProductName.ReadOnly = true;
                txtProductName.BackColor = Color.FromArgb(24, 30, 54);
                txtProductName.ForeColor = Color.White;
                txtProductName.BorderStyle = BorderStyle.FixedSingle;
                txtProductName.Text = "All Products";


                txtFileName.ReadOnly = true;
                txtFileName.BackColor = Color.FromArgb(24, 30, 54);
                txtFileName.ForeColor = Color.White;
                txtFileName.BorderStyle = BorderStyle.FixedSingle;
                txtFileName.Text = "All Products";

                txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Barcode\\";

            }
            else if (CmbGenarateMode.SelectedIndex == 1)
            {
                panelGetdata.Visible = true;
                btnGenarate.Visible = true;


                lblProductorCategory.Text = "Select Product";
                lblFileorFolder.Text = "File Name";
                cmbCategory.Visible = false;

                //txtProductName style
                txtProductName.ReadOnly = false;
                txtProductName.Visible = true;
                txtProductName.BackColor = Color.FromArgb(0, 122, 226);
                txtProductName.ForeColor = Color.Black;
                txtProductName.BorderStyle = BorderStyle.None;
                txtProductName.Text = "";


                //txtFileName style
                txtFileName.ReadOnly = false;
                txtFileName.BackColor = Color.FromArgb(0, 122, 226);
                txtFileName.ForeColor = Color.Black;
                txtFileName.BorderStyle = BorderStyle.None;
                txtFileName.Text = txtProductName.Text+".jpg";

                txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcode\\";

            }
            else if (CmbGenarateMode.SelectedIndex == 2)
            {
                panelGetdata.Visible = true;
                btnGenarate.Visible = true;


                lblProductorCategory.Text = "Select Category";
                lblFileorFolder.Text = "Folder Name";
                cmbCategory.Visible = true;


                //txtProductName style
                txtProductName.ReadOnly = false;
                txtProductName.Visible = false;
                txtProductName.BackColor = Color.FromArgb(0, 122, 226);
                txtProductName.ForeColor = Color.Black;
                txtProductName.BorderStyle = BorderStyle.None;
                txtProductName.Text = "";

                cmbCategory.SelectedIndex = -1;


                //txtFileName style
                txtFileName.ReadOnly = false;
                txtFileName.BackColor = Color.FromArgb(0, 122, 226);
                txtFileName.ForeColor = Color.Black;
                txtFileName.BorderStyle = BorderStyle.None;
                txtFileName.Text = "";

                txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcode\\"+txtFileName.Text;

            }
        }

        

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            txtFileName.Text = txtProductName.Text + ".jpg";
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            
            if (txtLocation.Text != "")
            {
                if (Path.GetDirectoryName(txtLocation.Text) == Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Barcode")
                {
                    txtLocation.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcode\\" + txtFileName.Text;
                }
                else if(Path.GetDirectoryName(txtLocation.Text)== @DirectoryName)
                {
                    txtLocation.Text = @DirectoryName + "\\" + txtFileName.Text;
                }
                
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFileName.Text = "Category " + cmbCategory.SelectedIndex;
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if(txtLocation.Text=="")
            {
                lblWorning.Text = "* Pleace select the location";
            }
            else
            {
                lblWorning.Text = "";
            }
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

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            if (Path.GetDirectoryName(txtLocation.Text) == Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcode" && !Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcodes"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Barcode");
            }
            if (CmbGenarateMode.SelectedIndex == 0)
            {
                Index0();
            }
            else if (CmbGenarateMode.SelectedIndex == 1)
            {
                Index1();
            }
            else if (CmbGenarateMode.SelectedIndex == 2)
            {
                Index2();
            }
            else
                MessageBox.Show("invalid input");
        }


        private void Index0()//all
        {
            string path = @txtLocation.Text+txtFileName.Text;
            MessageBox.Show(path);

            for(int i=1; Directory.Exists(path);i++)
            {
                path = Path.GetDirectoryName(txtLocation.Text) + "\\" + txtFileName.Text + i;
                txtLocation.Text = path;
              
            }
            Directory.CreateDirectory(path);

            string barcode = "";
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();

            string sql = @"SELECT PRODUCT_ID , PRODUCT_NAME FROM INVENTORY ORDER BY PRODUCT_ID ASC";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int i=0;
                while (reader.Read())
                {
                    barcode = reader.GetInt32(0).ToString();
                    //MessageBox.Show(barcode);

                    Bitmap bitmap = new Bitmap(barcode.Length * 30, 150);
                    using (Graphics grapics = Graphics.FromImage(bitmap))
                    {
                        Font ofont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);

                        PointF point = new PointF(2f, 2f);
                        SolidBrush black = new SolidBrush(Color.Black);
                        SolidBrush white = new SolidBrush(Color.White);
                        grapics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                        grapics.DrawString(barcode, ofont, black, point);

                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        pictureBoxBarcode.Image = bitmap;
                        pictureBoxBarcode.Height = bitmap.Height;
                        pictureBoxBarcode.Width = bitmap.Width;

                    }

                    FileStream fstream = new FileStream(@path+ "\\" + reader.GetString(1) + ".jpg", FileMode.Create);
                    pictureBoxBarcode.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();

                    //--------NOTIFICATION----------
                    i++;
                    lblNotifi.Text = "The Barcodes for "+i+ " Products\nGenarated & Saved Successfully! \n\nYou can Find that jpg files from\n"+path;
                    

                }
            }
        }


        private void Index1()//product
        {
            string path = txtLocation.Text;
            for (int i = 1; File.Exists(path); i++)
            {
                path = Path.GetDirectoryName(txtLocation.Text) + "\\" + txtProductName.Text + "(" + i + ").jpg";
                txtLocation.Text = path;

            }
            
            string barcode = "";
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();

            string sql = @"SELECT PRODUCT_ID FROM INVENTORY WHERE PRODUCT_NAME='" + txtProductName.Text + "'";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    barcode = reader.GetInt32(0).ToString();


                }
            }



            Bitmap bitmap = new Bitmap(barcode.Length * 30, 150);
            using (Graphics grapics = Graphics.FromImage(bitmap))
            {
                Font ofont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);

                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                grapics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                grapics.DrawString(barcode, ofont, black, point);

            }

            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);
                pictureBoxBarcode.Image = bitmap;
                pictureBoxBarcode.Height = bitmap.Height;
                pictureBoxBarcode.Width = bitmap.Width;

            }

            FileStream fstream = new FileStream(@path, FileMode.Create);
            pictureBoxBarcode.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();

            //--------NOTIFICATION----------
            lblNotifi.Text = "The Barcode for " + txtProductName.Text + "\nGenarated & Saved Successfully! \n\nYou can Find that jpg file from\n" + path;
        }




        private void Index2()//all
        {
            string path = @txtLocation.Text;
            MessageBox.Show(path);

            for (int i = 1; Directory.Exists(path); i++)
            {
                path = Path.GetDirectoryName(txtLocation.Text) + "\\" + txtFileName.Text +"(" +i+")";
                txtLocation.Text = path;

            }
            Directory.CreateDirectory(path);

            string barcode = "";
            SqlConnection con = new SqlConnection(connectDB.connectionstring);
            con.Open();

            string sql = @"SELECT PRODUCT_ID , PRODUCT_NAME FROM INVENTORY WHERE CATEGORY='"+cmbCategory.Text+"' ORDER BY PRODUCT_ID ASC";
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    barcode = reader.GetInt32(0).ToString();
                    //MessageBox.Show(barcode);

                    Bitmap bitmap = new Bitmap(barcode.Length * 30, 150);
                    using (Graphics grapics = Graphics.FromImage(bitmap))
                    {
                        Font ofont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 20);

                        PointF point = new PointF(2f, 2f);
                        SolidBrush black = new SolidBrush(Color.Black);
                        SolidBrush white = new SolidBrush(Color.White);
                        grapics.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                        grapics.DrawString(barcode, ofont, black, point);

                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bitmap.Save(ms, ImageFormat.Png);
                        pictureBoxBarcode.Image = bitmap;
                        pictureBoxBarcode.Height = bitmap.Height;
                        pictureBoxBarcode.Width = bitmap.Width;

                    }

                    FileStream fstream = new FileStream(@path + "\\" + reader.GetString(1) + ".jpg", FileMode.Create);
                    pictureBoxBarcode.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();


                    //--------NOTIFICATION----------
                    i++;
                    lblNotifi.Text = "The Barcodes for " + i + " Products of '"+cmbCategory.Text+"'\nGenarated & Saved Successfully! \n\nYou can Find that jpg files from \n" + path;
                   



                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetDirectoryName(txtLocation.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(Path.GetDirectoryName(txtLocation.Text));
            MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void lblNotifi_MouseHover(object sender, EventArgs e)
        {
            lblNotifi.ForeColor = Color.White;
        }

        private void lblNotifi_MouseLeave(object sender, EventArgs e)
        {
            lblNotifi.ForeColor = Color.FromArgb(0, 118, 163);
        }
    }
}
