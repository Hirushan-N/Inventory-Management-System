
namespace store_001
{
    partial class ViewMoreBillProdCat
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnRestoreDown = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btncategories = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.uC_Products1 = new store_001.UC_Products();
            this.uC_Categories1 = new store_001.UC_Categories();
            this.uC_Bills1 = new store_001.UC_Bills();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnRestoreDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1341, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 60);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinimize.Location = new System.Drawing.Point(1221, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Size = new System.Drawing.Size(60, 60);
            this.btnMinimize.TabIndex = 36;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestoreDown
            // 
            this.btnRestoreDown.BackColor = System.Drawing.Color.Black;
            this.btnRestoreDown.FlatAppearance.BorderSize = 0;
            this.btnRestoreDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDown.Font = new System.Drawing.Font("Webdings", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRestoreDown.ForeColor = System.Drawing.Color.White;
            this.btnRestoreDown.Location = new System.Drawing.Point(1281, 0);
            this.btnRestoreDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestoreDown.Name = "btnRestoreDown";
            this.btnRestoreDown.Size = new System.Drawing.Size(60, 60);
            this.btnRestoreDown.TabIndex = 37;
            this.btnRestoreDown.Text = "1";
            this.btnRestoreDown.UseVisualStyleBackColor = false;
            this.btnRestoreDown.Click += new System.EventHandler(this.btnRestoreDown_Click);
            // 
            // btnBills
            // 
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(0, 81);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(172, 55);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Bills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btncategories
            // 
            this.btncategories.FlatAppearance.BorderSize = 0;
            this.btncategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategories.ForeColor = System.Drawing.Color.White;
            this.btncategories.Location = new System.Drawing.Point(172, 82);
            this.btncategories.Name = "btncategories";
            this.btncategories.Size = new System.Drawing.Size(172, 55);
            this.btncategories.TabIndex = 2;
            this.btncategories.Text = "Categories";
            this.btncategories.UseVisualStyleBackColor = true;
            this.btncategories.Click += new System.EventHandler(this.btncategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(344, 81);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(172, 55);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // uC_Products1
            // 
            this.uC_Products1.Location = new System.Drawing.Point(-1, 136);
            this.uC_Products1.Name = "uC_Products1";
            this.uC_Products1.Size = new System.Drawing.Size(1406, 921);
            this.uC_Products1.TabIndex = 4;
            this.uC_Products1.Load += new System.EventHandler(this.uC_Products1_Load);
            // 
            // uC_Categories1
            // 
            this.uC_Categories1.BackColor = System.Drawing.Color.Black;
            this.uC_Categories1.Location = new System.Drawing.Point(0, 136);
            this.uC_Categories1.Name = "uC_Categories1";
            this.uC_Categories1.Size = new System.Drawing.Size(1402, 918);
            this.uC_Categories1.TabIndex = 3;
            // 
            // uC_Bills1
            // 
            this.uC_Bills1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uC_Bills1.BackColor = System.Drawing.Color.White;
            this.uC_Bills1.Location = new System.Drawing.Point(0, 135);
            this.uC_Bills1.Name = "uC_Bills1";
            this.uC_Bills1.Size = new System.Drawing.Size(1402, 918);
            this.uC_Bills1.TabIndex = 5;
            // 
            // ViewMoreBillProdCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1405, 1057);
            this.Controls.Add(this.uC_Bills1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncategories);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.uC_Products1);
            this.Controls.Add(this.uC_Categories1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMoreBillProdCat";
            this.Text = "ViewMoreBillProdCat";
            this.Load += new System.EventHandler(this.ViewMoreBillProdCat_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnRestoreDown;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btncategories;
        private System.Windows.Forms.Button btnProducts;
        private UC_Categories uC_Categories1;
        private UC_Products uC_Products1;
        private UC_Bills uC_Bills1;
    }
}