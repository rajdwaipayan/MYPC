namespace CoffeeShop
{
    partial class Form1
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
            this.customerNamelabel1 = new System.Windows.Forms.Label();
            this.contactNolabel2 = new System.Windows.Forms.Label();
            this.addresslabel3 = new System.Windows.Forms.Label();
            this.orderlabel4 = new System.Windows.Forms.Label();
            this.quantitylabel5 = new System.Windows.Forms.Label();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.contactNotextBox1 = new System.Windows.Forms.TextBox();
            this.customerNametextBox2 = new System.Windows.Forms.TextBox();
            this.addresstextBox3 = new System.Windows.Forms.TextBox();
            this.ordercomboBox1 = new System.Windows.Forms.ComboBox();
            this.quantitytextBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNamelabel1
            // 
            this.customerNamelabel1.AutoSize = true;
            this.customerNamelabel1.Location = new System.Drawing.Point(24, 42);
            this.customerNamelabel1.Name = "customerNamelabel1";
            this.customerNamelabel1.Size = new System.Drawing.Size(82, 13);
            this.customerNamelabel1.TabIndex = 0;
            this.customerNamelabel1.Text = "Customer Name";
            // 
            // contactNolabel2
            // 
            this.contactNolabel2.AutoSize = true;
            this.contactNolabel2.Location = new System.Drawing.Point(24, 84);
            this.contactNolabel2.Name = "contactNolabel2";
            this.contactNolabel2.Size = new System.Drawing.Size(61, 13);
            this.contactNolabel2.TabIndex = 1;
            this.contactNolabel2.Text = "Contact No";
            // 
            // addresslabel3
            // 
            this.addresslabel3.AutoSize = true;
            this.addresslabel3.Location = new System.Drawing.Point(24, 123);
            this.addresslabel3.Name = "addresslabel3";
            this.addresslabel3.Size = new System.Drawing.Size(45, 13);
            this.addresslabel3.TabIndex = 2;
            this.addresslabel3.Text = "Address";
            // 
            // orderlabel4
            // 
            this.orderlabel4.AutoSize = true;
            this.orderlabel4.Location = new System.Drawing.Point(24, 165);
            this.orderlabel4.Name = "orderlabel4";
            this.orderlabel4.Size = new System.Drawing.Size(33, 13);
            this.orderlabel4.TabIndex = 3;
            this.orderlabel4.Text = "Order";
            // 
            // quantitylabel5
            // 
            this.quantitylabel5.AutoSize = true;
            this.quantitylabel5.Location = new System.Drawing.Point(24, 214);
            this.quantitylabel5.Name = "quantitylabel5";
            this.quantitylabel5.Size = new System.Drawing.Size(46, 13);
            this.quantitylabel5.TabIndex = 4;
            this.quantitylabel5.Text = "Quantity";
            // 
            // savebutton1
            // 
            this.savebutton1.Location = new System.Drawing.Point(112, 258);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(75, 23);
            this.savebutton1.TabIndex = 5;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // contactNotextBox1
            // 
            this.contactNotextBox1.Location = new System.Drawing.Point(112, 81);
            this.contactNotextBox1.Name = "contactNotextBox1";
            this.contactNotextBox1.Size = new System.Drawing.Size(121, 20);
            this.contactNotextBox1.TabIndex = 6;
            this.contactNotextBox1.TextChanged += new System.EventHandler(this.contactNotextBox1_TextChanged);
            this.contactNotextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKeyPress);
            // 
            // customerNametextBox2
            // 
            this.customerNametextBox2.Location = new System.Drawing.Point(112, 42);
            this.customerNametextBox2.Name = "customerNametextBox2";
            this.customerNametextBox2.Size = new System.Drawing.Size(121, 20);
            this.customerNametextBox2.TabIndex = 7;
            // 
            // addresstextBox3
            // 
            this.addresstextBox3.Location = new System.Drawing.Point(112, 120);
            this.addresstextBox3.Name = "addresstextBox3";
            this.addresstextBox3.Size = new System.Drawing.Size(121, 20);
            this.addresstextBox3.TabIndex = 8;
            // 
            // ordercomboBox1
            // 
            this.ordercomboBox1.FormattingEnabled = true;
            this.ordercomboBox1.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.ordercomboBox1.Location = new System.Drawing.Point(112, 162);
            this.ordercomboBox1.Name = "ordercomboBox1";
            this.ordercomboBox1.Size = new System.Drawing.Size(121, 21);
            this.ordercomboBox1.TabIndex = 9;
            this.ordercomboBox1.SelectedIndexChanged += new System.EventHandler(this.ordercomboBox1_SelectedIndexChanged);
            this.ordercomboBox1.DropDownStyleChanged += new System.EventHandler(this.DropDownList);
            // 
            // quantitytextBox4
            // 
            this.quantitytextBox4.Location = new System.Drawing.Point(112, 207);
            this.quantitytextBox4.Name = "quantitytextBox4";
            this.quantitytextBox4.Size = new System.Drawing.Size(121, 20);
            this.quantitytextBox4.TabIndex = 10;
            this.quantitytextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityKeyPressed);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(316, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(186, 290);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savebutton1);
            this.groupBox1.Controls.Add(this.quantitytextBox4);
            this.groupBox1.Controls.Add(this.quantitylabel5);
            this.groupBox1.Controls.Add(this.customerNametextBox2);
            this.groupBox1.Controls.Add(this.orderlabel4);
            this.groupBox1.Controls.Add(this.addresslabel3);
            this.groupBox1.Controls.Add(this.addresstextBox3);
            this.groupBox1.Controls.Add(this.contactNolabel2);
            this.groupBox1.Controls.Add(this.contactNotextBox1);
            this.groupBox1.Controls.Add(this.customerNamelabel1);
            this.groupBox1.Controls.Add(this.ordercomboBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 326);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customerNamelabel1;
        private System.Windows.Forms.Label contactNolabel2;
        private System.Windows.Forms.Label addresslabel3;
        private System.Windows.Forms.Label orderlabel4;
        private System.Windows.Forms.Label quantitylabel5;
        private System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.TextBox contactNotextBox1;
        private System.Windows.Forms.TextBox customerNametextBox2;
        private System.Windows.Forms.TextBox addresstextBox3;
        private System.Windows.Forms.ComboBox ordercomboBox1;
        private System.Windows.Forms.TextBox quantitytextBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

