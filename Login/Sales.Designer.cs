namespace Login
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.label4 = new System.Windows.Forms.Label();
            this.dgsendsales = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSendSales = new System.Windows.Forms.Button();
            this.btnadminsales = new System.Windows.Forms.Button();
            this.btnadmincashier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnadmincategory = new System.Windows.Forms.Button();
            this.btnadmininventory = new System.Windows.Forms.Button();
            this.lblShopname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgsendsales)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgsendsales
            // 
            this.dgsendsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgsendsales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgsendsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsendsales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgsendsales.Location = new System.Drawing.Point(0, 59);
            this.dgsendsales.Name = "dgsendsales";
            this.dgsendsales.RowHeadersWidth = 51;
            this.dgsendsales.RowTemplate.Height = 24;
            this.dgsendsales.Size = new System.Drawing.Size(941, 534);
            this.dgsendsales.TabIndex = 6;
            this.dgsendsales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsales_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSendSales);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgsendsales);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(259, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(941, 649);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnSendSales
            // 
            this.btnSendSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSendSales.FlatAppearance.BorderSize = 0;
            this.btnSendSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendSales.ForeColor = System.Drawing.Color.White;
            this.btnSendSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendSales.Location = new System.Drawing.Point(391, 607);
            this.btnSendSales.Name = "btnSendSales";
            this.btnSendSales.Size = new System.Drawing.Size(164, 33);
            this.btnSendSales.TabIndex = 56;
            this.btnSendSales.Text = "Receive Sales Data";
            this.btnSendSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendSales.UseVisualStyleBackColor = false;
            this.btnSendSales.Click += new System.EventHandler(this.btnSendSales_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnadminsales);
            this.panel1.Controls.Add(this.btnadmincashier);
            this.panel1.Controls.Add(this.btnadmincategory);
            this.panel1.Controls.Add(this.btnadmininventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 649);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Login.Properties.Resources.logout_rounded_left_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btnadmininventory.Click += new System.EventHandler(this.btnadmininventory_Click);
            // 
            // lblShopname
            // 
            this.lblShopname.AutoSize = true;
            this.lblShopname.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShopname.Location = new System.Drawing.Point(21, 10);
            this.lblShopname.Name = "lblShopname";
            this.lblShopname.Size = new System.Drawing.Size(184, 38);
            this.lblShopname.TabIndex = 0;
            this.lblShopname.Text = "Green City\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1062, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblShopname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 51);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.customer_30px;
            this.pictureBox1.Location = new System.Drawing.Point(1026, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales - Greencity";
            ((System.ComponentModel.ISupportInitialize)(this.dgsendsales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgsendsales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnadminsales;
        private System.Windows.Forms.Button btnadmincashier;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadmincategory;
        private System.Windows.Forms.Button btnadmininventory;
        private System.Windows.Forms.Label lblShopname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSendSales;
    }
}