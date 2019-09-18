namespace Assignment4
{
    partial class Home
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
            this.NameTextBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderComboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowButton2 = new System.Windows.Forms.Button();
            this.ResetButton1 = new System.Windows.Forms.Button();
            this.AddButton1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.QuantityTextBox5 = new System.Windows.Forms.TextBox();
            this.AddressTextBox3 = new System.Windows.Forms.TextBox();
            this.ContactTextBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox1
            // 
            this.NameTextBox1.Location = new System.Drawing.Point(170, 45);
            this.NameTextBox1.Name = "NameTextBox1";
            this.NameTextBox1.Size = new System.Drawing.Size(192, 20);
            this.NameTextBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderComboBox1);
            this.groupBox1.Controls.Add(this.ShowButton2);
            this.groupBox1.Controls.Add(this.ResetButton1);
            this.groupBox1.Controls.Add(this.AddButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameLabel1);
            this.groupBox1.Controls.Add(this.QuantityTextBox5);
            this.groupBox1.Controls.Add(this.AddressTextBox3);
            this.groupBox1.Controls.Add(this.ContactTextBox2);
            this.groupBox1.Controls.Add(this.NameTextBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(45, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // OrderComboBox1
            // 
            this.OrderComboBox1.FormattingEnabled = true;
            this.OrderComboBox1.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.OrderComboBox1.Location = new System.Drawing.Point(170, 195);
            this.OrderComboBox1.Name = "OrderComboBox1";
            this.OrderComboBox1.Size = new System.Drawing.Size(192, 21);
            this.OrderComboBox1.TabIndex = 3;
            this.OrderComboBox1.Text = "Select an Item....";
            // 
            // ShowButton2
            // 
            this.ShowButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowButton2.Location = new System.Drawing.Point(268, 298);
            this.ShowButton2.Name = "ShowButton2";
            this.ShowButton2.Size = new System.Drawing.Size(75, 23);
            this.ShowButton2.TabIndex = 2;
            this.ShowButton2.Text = "Show";
            this.ShowButton2.UseVisualStyleBackColor = false;
            this.ShowButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // ResetButton1
            // 
            this.ResetButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton1.Location = new System.Drawing.Point(79, 298);
            this.ResetButton1.Name = "ResetButton1";
            this.ResetButton1.Size = new System.Drawing.Size(75, 23);
            this.ResetButton1.TabIndex = 2;
            this.ResetButton1.Text = "RESET";
            this.ResetButton1.UseVisualStyleBackColor = false;
            this.ResetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // AddButton1
            // 
            this.AddButton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton1.Location = new System.Drawing.Point(170, 298);
            this.AddButton1.Name = "AddButton1";
            this.AddButton1.Size = new System.Drawing.Size(75, 23);
            this.AddButton1.TabIndex = 2;
            this.AddButton1.Text = "Add";
            this.AddButton1.UseVisualStyleBackColor = false;
            this.AddButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact No.";
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Location = new System.Drawing.Point(43, 48);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(82, 13);
            this.nameLabel1.TabIndex = 1;
            this.nameLabel1.Text = "Customer Name";
            // 
            // QuantityTextBox5
            // 
            this.QuantityTextBox5.Location = new System.Drawing.Point(170, 242);
            this.QuantityTextBox5.Name = "QuantityTextBox5";
            this.QuantityTextBox5.Size = new System.Drawing.Size(192, 20);
            this.QuantityTextBox5.TabIndex = 0;
            this.QuantityTextBox5.TextChanged += new System.EventHandler(this.QuantityTextBox5_TextChanged);
            this.QuantityTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox5_KeyPress);
            // 
            // AddressTextBox3
            // 
            this.AddressTextBox3.Location = new System.Drawing.Point(170, 123);
            this.AddressTextBox3.Name = "AddressTextBox3";
            this.AddressTextBox3.Size = new System.Drawing.Size(192, 20);
            this.AddressTextBox3.TabIndex = 0;
            this.AddressTextBox3.TextChanged += new System.EventHandler(this.AddressTextBox3_TextChanged);
            // 
            // ContactTextBox2
            // 
            this.ContactTextBox2.Location = new System.Drawing.Point(170, 85);
            this.ContactTextBox2.Name = "ContactTextBox2";
            this.ContactTextBox2.Size = new System.Drawing.Size(192, 20);
            this.ContactTextBox2.TabIndex = 0;
            this.ContactTextBox2.TextChanged += new System.EventHandler(this.contactTextBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(461, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(231, 349);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 435);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Home";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox OrderComboBox1;
        private System.Windows.Forms.Button ShowButton2;
        private System.Windows.Forms.Button AddButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox QuantityTextBox5;
        private System.Windows.Forms.TextBox AddressTextBox3;
        private System.Windows.Forms.TextBox ContactTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ResetButton1;
    }
}

