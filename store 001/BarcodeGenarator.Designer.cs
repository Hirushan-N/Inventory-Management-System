
namespace store_001
{
    partial class BarcodeGenarator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.lblNotifi = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.CmbGenarateMode = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProductorCategory = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.lblFileorFolder = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.panelGetdata = new System.Windows.Forms.Panel();
            this.lblWorning = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.panelGetdata.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pictureBoxBarcode);
            this.panel1.Location = new System.Drawing.Point(687, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 277);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(36, 16);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(365, 203);
            this.pictureBoxBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBarcode.TabIndex = 0;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // lblNotifi
            // 
            this.lblNotifi.AutoSize = true;
            this.lblNotifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNotifi.Font = new System.Drawing.Font("Nirmala UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(163)))));
            this.lblNotifi.Location = new System.Drawing.Point(19, 573);
            this.lblNotifi.Name = "lblNotifi";
            this.lblNotifi.Size = new System.Drawing.Size(74, 20);
            this.lblNotifi.TabIndex = 4;
            this.lblNotifi.Text = "File Name";
            this.lblNotifi.UseMnemonic = false;
            this.lblNotifi.MouseLeave += new System.EventHandler(this.lblNotifi_MouseLeave);
            this.lblNotifi.MouseHover += new System.EventHandler(this.lblNotifi_MouseHover);
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.Location = new System.Drawing.Point(62, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(577, 34);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // CmbGenarateMode
            // 
            this.CmbGenarateMode.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.CmbGenarateMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.CmbGenarateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenarateMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbGenarateMode.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGenarateMode.ForeColor = System.Drawing.Color.Black;
            this.CmbGenarateMode.FormattingEnabled = true;
            this.CmbGenarateMode.Items.AddRange(new object[] {
            "All Products",
            "For One Product",
            "For Category"});
            this.CmbGenarateMode.Location = new System.Drawing.Point(84, 154);
            this.CmbGenarateMode.Name = "CmbGenarateMode";
            this.CmbGenarateMode.Size = new System.Drawing.Size(427, 36);
            this.CmbGenarateMode.TabIndex = 3;
            this.CmbGenarateMode.SelectedIndexChanged += new System.EventHandler(this.CmbGenarateMode_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.cmbCategory.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(62, 52);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(577, 36);
            this.cmbCategory.TabIndex = 3;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genarate Mode";
            // 
            // lblProductorCategory
            // 
            this.lblProductorCategory.AutoSize = true;
            this.lblProductorCategory.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductorCategory.ForeColor = System.Drawing.Color.White;
            this.lblProductorCategory.Location = new System.Drawing.Point(5, 17);
            this.lblProductorCategory.Name = "lblProductorCategory";
            this.lblProductorCategory.Size = new System.Drawing.Size(58, 23);
            this.lblProductorCategory.TabIndex = 4;
            this.lblProductorCategory.Text = "Select";
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.Location = new System.Drawing.Point(62, 266);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(960, 34);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowseLocation.FlatAppearance.BorderSize = 0;
            this.btnBrowseLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseLocation.ForeColor = System.Drawing.Color.White;
            this.btnBrowseLocation.Location = new System.Drawing.Point(1043, 263);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(33, 37);
            this.btnBrowseLocation.TabIndex = 5;
            this.btnBrowseLocation.Text = ":::";
            this.btnBrowseLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowseLocation.UseVisualStyleBackColor = false;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            // 
            // lblFileorFolder
            // 
            this.lblFileorFolder.AutoSize = true;
            this.lblFileorFolder.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileorFolder.ForeColor = System.Drawing.Color.White;
            this.lblFileorFolder.Location = new System.Drawing.Point(5, 118);
            this.lblFileorFolder.Name = "lblFileorFolder";
            this.lblFileorFolder.Size = new System.Drawing.Size(90, 23);
            this.lblFileorFolder.TabIndex = 4;
            this.lblFileorFolder.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(226)))));
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.Color.Black;
            this.txtFileName.Location = new System.Drawing.Point(62, 157);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(577, 34);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // btnGenarate
            // 
            this.btnGenarate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btnGenarate.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGenarate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarate.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.ForeColor = System.Drawing.Color.White;
            this.btnGenarate.Location = new System.Drawing.Point(806, 562);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(301, 68);
            this.btnGenarate.TabIndex = 6;
            this.btnGenarate.Text = "Genarate & Save";
            this.btnGenarate.UseMnemonic = false;
            this.btnGenarate.UseVisualStyleBackColor = false;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // panelGetdata
            // 
            this.panelGetdata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGetdata.Controls.Add(this.lblWorning);
            this.panelGetdata.Controls.Add(this.btnBrowseLocation);
            this.panelGetdata.Controls.Add(this.txtFileName);
            this.panelGetdata.Controls.Add(this.label3);
            this.panelGetdata.Controls.Add(this.txtLocation);
            this.panelGetdata.Controls.Add(this.lblProductorCategory);
            this.panelGetdata.Controls.Add(this.lblFileorFolder);
            this.panelGetdata.Controls.Add(this.txtProductName);
            this.panelGetdata.Controls.Add(this.cmbCategory);
            this.panelGetdata.Location = new System.Drawing.Point(17, 206);
            this.panelGetdata.Name = "panelGetdata";
            this.panelGetdata.Size = new System.Drawing.Size(1090, 350);
            this.panelGetdata.TabIndex = 7;
            // 
            // lblWorning
            // 
            this.lblWorning.AutoSize = true;
            this.lblWorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorning.ForeColor = System.Drawing.Color.Red;
            this.lblWorning.Location = new System.Drawing.Point(668, 308);
            this.lblWorning.Name = "lblWorning";
            this.lblWorning.Size = new System.Drawing.Size(0, 17);
            this.lblWorning.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1096, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.Location = new System.Drawing.Point(1044, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 37;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbltitle);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 100);
            this.panel2.TabIndex = 38;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::store_001.Properties.Resources.pngegg__1_;
            this.pictureBox1.Location = new System.Drawing.Point(32, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(146, 31);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(377, 46);
            this.lbltitle.TabIndex = 38;
            this.lbltitle.Text = "Barcode Genarator";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(17, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 350);
            this.panel3.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label6.Location = new System.Drawing.Point(167, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 69);
            this.label6.TabIndex = 38;
            this.label6.Text = "MODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(167, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(368, 69);
            this.label5.TabIndex = 38;
            this.label5.Text = "GENARATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(444, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 69);
            this.label4.TabIndex = 38;
            this.label4.Text = "THE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(167, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 69);
            this.label8.TabIndex = 38;
            this.label8.Text = "PLEASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(167, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 69);
            this.label2.TabIndex = 38;
            this.label2.Text = "SELECT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 169.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(-25, -7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 322);
            this.label7.TabIndex = 38;
            this.label7.Text = "↑";
            // 
            // BarcodeGenarator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1150, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNotifi);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbGenarateMode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelGetdata);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeGenarator";
            this.Text = "BarcodeGenarator";
            this.Load += new System.EventHandler(this.BarcodeGenarator_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.panelGetdata.ResumeLayout(false);
            this.panelGetdata.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox CmbGenarateMode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProductorCategory;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.Label lblNotifi;
        private System.Windows.Forms.Label lblFileorFolder;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.Panel panelGetdata;
        private System.Windows.Forms.Label lblWorning;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}