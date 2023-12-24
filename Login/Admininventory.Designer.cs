namespace Login
{
    partial class Admininventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admininventory));
            this.cbprcategory = new System.Windows.Forms.ComboBox();
            this.txtprprice = new System.Windows.Forms.TextBox();
            this.lblprprice = new System.Windows.Forms.Label();
            this.btnprupdate = new System.Windows.Forms.Button();
            this.btnprdelete = new System.Windows.Forms.Button();
            this.btnpradd = new System.Windows.Forms.Button();
            this.txtprquant = new System.Windows.Forms.TextBox();
            this.lblinvquant = new System.Windows.Forms.Label();
            this.txtprname = new System.Windows.Forms.TextBox();
            this.lblprname = new System.Windows.Forms.Label();
            this.txtprid = new System.Windows.Forms.TextBox();
            this.lblprid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbsecategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblprcategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgcategory = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnadminsales = new System.Windows.Forms.Button();
            this.btnadmincashier = new System.Windows.Forms.Button();
            this.btnadmincategory = new System.Windows.Forms.Button();
            this.btnadmininventory = new System.Windows.Forms.Button();
            this.lblShopname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbprcategory
            // 
            this.cbprcategory.FormattingEnabled = true;
            this.cbprcategory.Location = new System.Drawing.Point(649, 69);
            this.cbprcategory.Name = "cbprcategory";
            this.cbprcategory.Size = new System.Drawing.Size(240, 24);
            this.cbprcategory.TabIndex = 16;
            this.cbprcategory.SelectedIndexChanged += new System.EventHandler(this.cbprcategory_SelectedIndexChanged);
            // 
            // txtprprice
            // 
            this.txtprprice.Location = new System.Drawing.Point(649, 27);
            this.txtprprice.Name = "txtprprice";
            this.txtprprice.Size = new System.Drawing.Size(240, 22);
            this.txtprprice.TabIndex = 13;
            // 
            // lblprprice
            // 
            this.lblprprice.AutoSize = true;
            this.lblprprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprprice.ForeColor = System.Drawing.Color.White;
            this.lblprprice.Location = new System.Drawing.Point(511, 27);
            this.lblprprice.Name = "lblprprice";
            this.lblprprice.Size = new System.Drawing.Size(53, 20);
            this.lblprprice.TabIndex = 12;
            this.lblprprice.Text = "Price";
            // 
            // btnprupdate
            // 
            this.btnprupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprupdate.FlatAppearance.BorderSize = 0;
            this.btnprupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprupdate.ForeColor = System.Drawing.Color.White;
            this.btnprupdate.Location = new System.Drawing.Point(160, 169);
            this.btnprupdate.Name = "btnprupdate";
            this.btnprupdate.Size = new System.Drawing.Size(106, 31);
            this.btnprupdate.TabIndex = 11;
            this.btnprupdate.Text = "Update";
            this.btnprupdate.UseVisualStyleBackColor = false;
            this.btnprupdate.Click += new System.EventHandler(this.btnprupdate_Click);
            // 
            // btnprdelete
            // 
            this.btnprdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnprdelete.FlatAppearance.BorderSize = 0;
            this.btnprdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprdelete.ForeColor = System.Drawing.Color.White;
            this.btnprdelete.Location = new System.Drawing.Point(294, 169);
            this.btnprdelete.Name = "btnprdelete";
            this.btnprdelete.Size = new System.Drawing.Size(106, 31);
            this.btnprdelete.TabIndex = 10;
            this.btnprdelete.Text = "Delete";
            this.btnprdelete.UseVisualStyleBackColor = false;
            this.btnprdelete.Click += new System.EventHandler(this.btnprdelete_Click);
            // 
            // btnpradd
            // 
            this.btnpradd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpradd.FlatAppearance.BorderSize = 0;
            this.btnpradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpradd.ForeColor = System.Drawing.Color.White;
            this.btnpradd.Location = new System.Drawing.Point(27, 169);
            this.btnpradd.Name = "btnpradd";
            this.btnpradd.Size = new System.Drawing.Size(106, 31);
            this.btnpradd.TabIndex = 8;
            this.btnpradd.Text = "Add";
            this.btnpradd.UseVisualStyleBackColor = false;
            this.btnpradd.Click += new System.EventHandler(this.btnpradd_Click);
            // 
            // txtprquant
            // 
            this.txtprquant.Location = new System.Drawing.Point(160, 114);
            this.txtprquant.Name = "txtprquant";
            this.txtprquant.Size = new System.Drawing.Size(240, 22);
            this.txtprquant.TabIndex = 7;
            // 
            // lblinvquant
            // 
            this.lblinvquant.AutoSize = true;
            this.lblinvquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvquant.ForeColor = System.Drawing.Color.White;
            this.lblinvquant.Location = new System.Drawing.Point(22, 114);
            this.lblinvquant.Name = "lblinvquant";
            this.lblinvquant.Size = new System.Drawing.Size(79, 20);
            this.lblinvquant.TabIndex = 6;
            this.lblinvquant.Text = "Quantity";
            // 
            // txtprname
            // 
            this.txtprname.Location = new System.Drawing.Point(160, 69);
            this.txtprname.Name = "txtprname";
            this.txtprname.Size = new System.Drawing.Size(240, 22);
            this.txtprname.TabIndex = 5;
            // 
            // lblprname
            // 
            this.lblprname.AutoSize = true;
            this.lblprname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprname.ForeColor = System.Drawing.Color.White;
            this.lblprname.Location = new System.Drawing.Point(22, 69);
            this.lblprname.Name = "lblprname";
            this.lblprname.Size = new System.Drawing.Size(57, 20);
            this.lblprname.TabIndex = 4;
            this.lblprname.Text = "Name";
            // 
            // txtprid
            // 
            this.txtprid.Location = new System.Drawing.Point(160, 27);
            this.txtprid.Name = "txtprid";
            this.txtprid.Size = new System.Drawing.Size(240, 22);
            this.txtprid.TabIndex = 3;
            // 
            // lblprid
            // 
            this.lblprid.AutoSize = true;
            this.lblprid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprid.ForeColor = System.Drawing.Color.White;
            this.lblprid.Location = new System.Drawing.Point(22, 24);
            this.lblprid.Name = "lblprid";
            this.lblprid.Size = new System.Drawing.Size(28, 20);
            this.lblprid.TabIndex = 0;
            this.lblprid.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cbsecategory);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgcategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 649);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbsecategory
            // 
            this.cbsecategory.FormattingEnabled = true;
            this.cbsecategory.Location = new System.Drawing.Point(577, 38);
            this.cbsecategory.Name = "cbsecategory";
            this.cbsecategory.Size = new System.Drawing.Size(240, 24);
            this.cbsecategory.TabIndex = 17;
            this.cbsecategory.Text = "Select Category";
            this.cbsecategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbsecategory.SelectionChangeCommitted += new System.EventHandler(this.abc);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(823, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.cbprcategory);
            this.panel4.Controls.Add(this.lblprcategory);
            this.panel4.Controls.Add(this.txtprprice);
            this.panel4.Controls.Add(this.lblprprice);
            this.panel4.Controls.Add(this.btnprupdate);
            this.panel4.Controls.Add(this.btnprdelete);
            this.panel4.Controls.Add(this.btnpradd);
            this.panel4.Controls.Add(this.txtprquant);
            this.panel4.Controls.Add(this.lblinvquant);
            this.panel4.Controls.Add(this.txtprname);
            this.panel4.Controls.Add(this.lblprname);
            this.panel4.Controls.Add(this.txtprid);
            this.panel4.Controls.Add(this.lblprid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 212);
            this.panel4.TabIndex = 5;
            // 
            // lblprcategory
            // 
            this.lblprcategory.AutoSize = true;
            this.lblprcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprcategory.ForeColor = System.Drawing.Color.White;
            this.lblprcategory.Location = new System.Drawing.Point(511, 69);
            this.lblprcategory.Name = "lblprcategory";
            this.lblprcategory.Size = new System.Drawing.Size(84, 20);
            this.lblprcategory.TabIndex = 14;
            this.lblprcategory.Text = "Category";
            this.lblprcategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventory";
            // 
            // dgcategory
            // 
            this.dgcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcategory.Location = new System.Drawing.Point(3, 68);
            this.dgcategory.Name = "dgcategory";
            this.dgcategory.RowHeadersWidth = 51;
            this.dgcategory.RowTemplate.Height = 24;
            this.dgcategory.Size = new System.Drawing.Size(936, 363);
            this.dgcategory.TabIndex = 3;
            this.dgcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcategory_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 51);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(798, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.customer_30px;
            this.pictureBox1.Location = new System.Drawing.Point(762, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnadminsales
            // 
            this.btnadminsales.FlatAppearance.BorderSize = 0;
            this.btnadminsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadminsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadminsales.ForeColor = System.Drawing.Color.White;
            this.btnadminsales.Location = new System.Drawing.Point(0, 366);
            this.btnadminsales.Name = "btnadminsales";
            this.btnadminsales.Size = new System.Drawing.Size(259, 55);
            this.btnadminsales.TabIndex = 3;
            this.btnadminsales.Text = "Sales";
            this.btnadminsales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadminsales.UseVisualStyleBackColor = true;
            this.btnadminsales.Click += new System.EventHandler(this.btnadminsales_Click);
            // 
            // btnadmincashier
            // 
            this.btnadmincashier.FlatAppearance.BorderSize = 0;
            this.btnadmincashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmincashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmincashier.ForeColor = System.Drawing.Color.White;
            this.btnadmincashier.Location = new System.Drawing.Point(0, 314);
            this.btnadmincashier.Name = "btnadmincashier";
            this.btnadmincashier.Size = new System.Drawing.Size(259, 55);
            this.btnadmincashier.TabIndex = 2;
            this.btnadmincashier.Text = "Cashier";
            this.btnadmincashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmincashier.UseVisualStyleBackColor = true;
            this.btnadmincashier.Click += new System.EventHandler(this.btnadmincashier_Click);
            // 
            // btnadmincategory
            // 
            this.btnadmincategory.FlatAppearance.BorderSize = 0;
            this.btnadmincategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmincategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmincategory.ForeColor = System.Drawing.Color.White;
            this.btnadmincategory.Location = new System.Drawing.Point(0, 263);
            this.btnadmincategory.Name = "btnadmincategory";
            this.btnadmincategory.Size = new System.Drawing.Size(259, 55);
            this.btnadmincategory.TabIndex = 1;
            this.btnadmincategory.Text = "Category";
            this.btnadmincategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmincategory.UseVisualStyleBackColor = true;
            this.btnadmincategory.Click += new System.EventHandler(this.btnadmincategory_Click);
            // 
            // btnadmininventory
            // 
            this.btnadmininventory.FlatAppearance.BorderSize = 0;
            this.btnadmininventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadmininventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmininventory.ForeColor = System.Drawing.Color.White;
            this.btnadmininventory.Location = new System.Drawing.Point(0, 211);
            this.btnadmininventory.Name = "btnadmininventory";
            this.btnadmininventory.Size = new System.Drawing.Size(259, 55);
            this.btnadmininventory.TabIndex = 0;
            this.btnadmininventory.Text = "Inventory";
            this.btnadmininventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmininventory.UseVisualStyleBackColor = true;
            // 
            // lblShopname
            // 
            this.lblShopname.AutoSize = true;
            this.lblShopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShopname.Location = new System.Drawing.Point(22, 9);
            this.lblShopname.Name = "lblShopname";
            this.lblShopname.Size = new System.Drawing.Size(184, 38);
            this.lblShopname.TabIndex = 0;
            this.lblShopname.Text = "Green City\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnadminsales);
            this.panel1.Controls.Add(this.btnadmincashier);
            this.panel1.Controls.Add(this.btnadmincategory);
            this.panel1.Controls.Add(this.btnadmininventory);
            this.panel1.Controls.Add(this.lblShopname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 700);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = global::Login.Properties.Resources.logout_rounded_left_30px;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 645);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(161, 55);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // Admininventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admininventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Inventory - Greencity";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbprcategory;
        private System.Windows.Forms.TextBox txtprprice;
        private System.Windows.Forms.Label lblprprice;
        private System.Windows.Forms.Button btnprupdate;
        private System.Windows.Forms.Button btnprdelete;
        private System.Windows.Forms.Button btnpradd;
        private System.Windows.Forms.TextBox txtprquant;
        private System.Windows.Forms.Label lblinvquant;
        private System.Windows.Forms.TextBox txtprname;
        private System.Windows.Forms.Label lblprname;
        private System.Windows.Forms.TextBox txtprid;
        private System.Windows.Forms.Label lblprid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblprcategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgcategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnadminsales;
        private System.Windows.Forms.Button btnadmincashier;
        private System.Windows.Forms.Button btnadmincategory;
        private System.Windows.Forms.Button btnadmininventory;
        private System.Windows.Forms.Label lblShopname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbsecategory;
    }
}