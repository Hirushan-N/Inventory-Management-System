
namespace store_001
{
    partial class INVENTORY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFormHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.BtnEditAdd = new System.Windows.Forms.Button();
            this.btnMenuEdit = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnMenuView = new System.Windows.Forms.Button();
            this.ucViewProduct1 = new store_001.UCViewProduct();
            this.DGViewAll = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucViewCategory1 = new store_001.UCViewCategory();
            this.panelFormHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormHeader
            // 
            this.panelFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.panelFormHeader.Controls.Add(this.label2);
            this.panelFormHeader.Controls.Add(this.panel3);
            this.panelFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFormHeader.Name = "panelFormHeader";
            this.panelFormHeader.Size = new System.Drawing.Size(1127, 110);
            this.panelFormHeader.TabIndex = 0;
            this.panelFormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseDown);
            this.panelFormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseMove);
            this.panelFormHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeadingPanel_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 46);
            this.label2.TabIndex = 36;
            this.label2.Text = "INVENTORY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseMnemonic = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(981, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 110);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnRestoreDown);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(146, 42);
            this.panel4.TabIndex = 36;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(96, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 42);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.Location = new System.Drawing.Point(7, -9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(46, 59);
            this.btnMinimize.TabIndex = 33;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(124)))));
            this.btnRestoreDown.FlatAppearance.BorderSize = 0;
            this.btnRestoreDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDown.Font = new System.Drawing.Font("Webdings", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRestoreDown.ForeColor = System.Drawing.Color.White;
            this.btnRestoreDown.Location = new System.Drawing.Point(49, -11);
            this.btnRestoreDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(50, 59);
            this.btnRestoreDown.TabIndex = 34;
            this.btnRestoreDown.Text = "1";
            this.btnRestoreDown.UseVisualStyleBackColor = false;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(95)))));
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.ucViewProduct1);
            this.panel7.Controls.Add(this.DGViewAll);
            this.panel7.Controls.Add(this.ucViewCategory1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 110);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1127, 655);
            this.panel7.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 655);
            this.panel1.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.AutoScrollMinSize = new System.Drawing.Size(4, 4);
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.panel9);
            this.panelMenu.Controls.Add(this.btnMenuEdit);
            this.panelMenu.Controls.Add(this.panel10);
            this.panelMenu.Controls.Add(this.btnMenuView);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 655);
            this.panelMenu.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 934);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 78);
            this.panel2.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 635);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 299);
            this.panel5.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkCyan;
            this.panel9.Controls.Add(this.btnEditDelete);
            this.panel9.Controls.Add(this.btnEditUpdate);
            this.panel9.Controls.Add(this.BtnEditAdd);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 416);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(259, 219);
            this.panel9.TabIndex = 10;
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditDelete.FlatAppearance.BorderSize = 0;
            this.btnEditDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelete.ForeColor = System.Drawing.Color.White;
            this.btnEditDelete.Location = new System.Drawing.Point(0, 120);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEditDelete.Size = new System.Drawing.Size(259, 60);
            this.btnEditDelete.TabIndex = 12;
            this.btnEditDelete.Text = "Delete";
            this.btnEditDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDelete.UseVisualStyleBackColor = false;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnEditUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditUpdate.FlatAppearance.BorderSize = 0;
            this.btnEditUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.ForeColor = System.Drawing.Color.White;
            this.btnEditUpdate.Location = new System.Drawing.Point(0, 60);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEditUpdate.Size = new System.Drawing.Size(259, 60);
            this.btnEditUpdate.TabIndex = 11;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // BtnEditAdd
            // 
            this.BtnEditAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditAdd.FlatAppearance.BorderSize = 0;
            this.BtnEditAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnEditAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditAdd.ForeColor = System.Drawing.Color.White;
            this.BtnEditAdd.Location = new System.Drawing.Point(0, 0);
            this.BtnEditAdd.Name = "BtnEditAdd";
            this.BtnEditAdd.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnEditAdd.Size = new System.Drawing.Size(259, 60);
            this.BtnEditAdd.TabIndex = 10;
            this.BtnEditAdd.Text = "Add New";
            this.BtnEditAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditAdd.UseVisualStyleBackColor = false;
            this.BtnEditAdd.Click += new System.EventHandler(this.BtnEditAdd_Click);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.BackColor = System.Drawing.Color.Black;
            this.btnMenuEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEdit.FlatAppearance.BorderSize = 0;
            this.btnMenuEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnMenuEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuEdit.ForeColor = System.Drawing.Color.White;
            this.btnMenuEdit.Location = new System.Drawing.Point(0, 316);
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuEdit.Size = new System.Drawing.Size(259, 100);
            this.btnMenuEdit.TabIndex = 9;
            this.btnMenuEdit.Text = "Edit";
            this.btnMenuEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEdit.UseVisualStyleBackColor = false;
            this.btnMenuEdit.Click += new System.EventHandler(this.btnMenuEdit_Click_1);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkCyan;
            this.panel10.Controls.Add(this.btnViewCategory);
            this.panel10.Controls.Add(this.btnViewProduct);
            this.panel10.Controls.Add(this.btnViewAll);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 100);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(259, 216);
            this.panel10.TabIndex = 8;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCategory.FlatAppearance.BorderSize = 0;
            this.btnViewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCategory.ForeColor = System.Drawing.Color.White;
            this.btnViewCategory.Location = new System.Drawing.Point(0, 120);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnViewCategory.Size = new System.Drawing.Size(259, 60);
            this.btnViewCategory.TabIndex = 10;
            this.btnViewCategory.Text = "Category";
            this.btnViewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCategory.UseVisualStyleBackColor = false;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.Location = new System.Drawing.Point(0, 60);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnViewProduct.Size = new System.Drawing.Size(259, 60);
            this.btnViewProduct.TabIndex = 9;
            this.btnViewProduct.Text = "Product";
            this.btnViewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAll.FlatAppearance.BorderSize = 0;
            this.btnViewAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(0, 0);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnViewAll.Size = new System.Drawing.Size(259, 60);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnMenuView
            // 
            this.btnMenuView.BackColor = System.Drawing.Color.Black;
            this.btnMenuView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuView.FlatAppearance.BorderSize = 0;
            this.btnMenuView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnMenuView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuView.ForeColor = System.Drawing.Color.White;
            this.btnMenuView.Location = new System.Drawing.Point(0, 0);
            this.btnMenuView.Name = "btnMenuView";
            this.btnMenuView.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnMenuView.Size = new System.Drawing.Size(259, 100);
            this.btnMenuView.TabIndex = 7;
            this.btnMenuView.Text = "View Stock";
            this.btnMenuView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuView.UseVisualStyleBackColor = false;
            this.btnMenuView.Click += new System.EventHandler(this.btnMenuView_Click_1);
            // 
            // ucViewProduct1
            // 
            this.ucViewProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucViewProduct1.Location = new System.Drawing.Point(278, -1);
            this.ucViewProduct1.Name = "ucViewProduct1";
            this.ucViewProduct1.Size = new System.Drawing.Size(849, 657);
            this.ucViewProduct1.TabIndex = 11;
            // 
            // DGViewAll
            // 
            this.DGViewAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGViewAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGViewAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGViewAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.DGViewAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGViewAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGViewAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewAll.ColumnHeadersVisible = false;
            this.DGViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGViewAll.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGViewAll.GridColor = System.Drawing.Color.Teal;
            this.DGViewAll.Location = new System.Drawing.Point(278, 0);
            this.DGViewAll.MultiSelect = false;
            this.DGViewAll.Name = "DGViewAll";
            this.DGViewAll.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGViewAll.RowHeadersVisible = false;
            this.DGViewAll.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.DGViewAll.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGViewAll.RowTemplate.DividerHeight = 5;
            this.DGViewAll.RowTemplate.Height = 50;
            this.DGViewAll.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGViewAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGViewAll.Size = new System.Drawing.Size(849, 661);
            this.DGViewAll.TabIndex = 1;
            this.DGViewAll.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGViewAll_MouseClick);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20);
            this.ProductID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductID.Frozen = true;
            this.ProductID.HeaderText = "Product Id";
            this.ProductID.MaxInputLength = 567;
            this.ProductID.MinimumWidth = 3;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 309.6775F;
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 58.06451F;
            this.Column2.HeaderText = "Available Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 58.06451F;
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 58.06451F;
            this.Column4.HeaderText = "Last Update";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 58.06451F;
            this.Column5.HeaderText = "Price taken";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 58.06451F;
            this.Column6.HeaderText = "Unit Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // ucViewCategory1
            // 
            this.ucViewCategory1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucViewCategory1.Location = new System.Drawing.Point(278, 1);
            this.ucViewCategory1.Name = "ucViewCategory1";
            this.ucViewCategory1.Size = new System.Drawing.Size(849, 657);
            this.ucViewCategory1.TabIndex = 10;
            // 
            // INVENTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1127, 765);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelFormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INVENTORY";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Navigator_Load);
            this.panelFormHeader.ResumeLayout(false);
            this.panelFormHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormHeader;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRestoreDown;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView DGViewAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button BtnEditAdd;
        private System.Windows.Forms.Button btnMenuEdit;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnMenuView;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Panel panel5;
        private UCViewCategory ucViewCategory1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private UCViewProduct ucViewProduct1;
    }
}