namespace Assignment6
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderIdTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.orderItemTextBox = new System.Windows.Forms.TextBox();
            this.orderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.orderDataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton1 = new System.Windows.Forms.Button();
            this.showButton2 = new System.Windows.Forms.Button();
            this.updateButton4 = new System.Windows.Forms.Button();
            this.deleteButton5 = new System.Windows.Forms.Button();
            this.searchButton6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ITEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order ID";
            // 
            // orderIdTextBox
            // 
            this.orderIdTextBox.Location = new System.Drawing.Point(177, 86);
            this.orderIdTextBox.Name = "orderIdTextBox";
            this.orderIdTextBox.Size = new System.Drawing.Size(116, 20);
            this.orderIdTextBox.TabIndex = 5;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(177, 122);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.customerNameTextBox.TabIndex = 6;
            // 
            // orderItemTextBox
            // 
            this.orderItemTextBox.Location = new System.Drawing.Point(177, 159);
            this.orderItemTextBox.Name = "orderItemTextBox";
            this.orderItemTextBox.Size = new System.Drawing.Size(116, 20);
            this.orderItemTextBox.TabIndex = 7;
            // 
            // orderQuantityTextBox
            // 
            this.orderQuantityTextBox.Location = new System.Drawing.Point(177, 196);
            this.orderQuantityTextBox.Name = "orderQuantityTextBox";
            this.orderQuantityTextBox.Size = new System.Drawing.Size(116, 20);
            this.orderQuantityTextBox.TabIndex = 8;
            // 
            // orderDataGridView1
            // 
            this.orderDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView1.Location = new System.Drawing.Point(343, 45);
            this.orderDataGridView1.Name = "orderDataGridView1";
            this.orderDataGridView1.Size = new System.Drawing.Size(369, 281);
            this.orderDataGridView1.TabIndex = 10;
            this.orderDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView1_CellContentClick);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(81, 356);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(79, 22);
            this.addButton1.TabIndex = 11;
            this.addButton1.Text = "ADD";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // showButton2
            // 
            this.showButton2.Location = new System.Drawing.Point(176, 356);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(79, 22);
            this.showButton2.TabIndex = 12;
            this.showButton2.Text = "Show";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // updateButton4
            // 
            this.updateButton4.Location = new System.Drawing.Point(271, 356);
            this.updateButton4.Name = "updateButton4";
            this.updateButton4.Size = new System.Drawing.Size(86, 22);
            this.updateButton4.TabIndex = 14;
            this.updateButton4.Text = "Update";
            this.updateButton4.UseVisualStyleBackColor = true;
            this.updateButton4.Click += new System.EventHandler(this.updateButton4_Click);
            // 
            // deleteButton5
            // 
            this.deleteButton5.Location = new System.Drawing.Point(377, 356);
            this.deleteButton5.Name = "deleteButton5";
            this.deleteButton5.Size = new System.Drawing.Size(73, 22);
            this.deleteButton5.TabIndex = 15;
            this.deleteButton5.Text = "Delete";
            this.deleteButton5.UseVisualStyleBackColor = true;
            this.deleteButton5.Click += new System.EventHandler(this.deleteButton5_Click);
            // 
            // searchButton6
            // 
            this.searchButton6.Location = new System.Drawing.Point(475, 356);
            this.searchButton6.Name = "searchButton6";
            this.searchButton6.Size = new System.Drawing.Size(67, 22);
            this.searchButton6.TabIndex = 16;
            this.searchButton6.Text = "Search";
            this.searchButton6.UseVisualStyleBackColor = true;
            this.searchButton6.Click += new System.EventHandler(this.searchButton6_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 459);
            this.Controls.Add(this.searchButton6);
            this.Controls.Add(this.deleteButton5);
            this.Controls.Add(this.updateButton4);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.orderDataGridView1);
            this.Controls.Add(this.orderQuantityTextBox);
            this.Controls.Add(this.orderItemTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.orderIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderIdTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox orderItemTextBox;
        private System.Windows.Forms.TextBox orderQuantityTextBox;
        private System.Windows.Forms.DataGridView orderDataGridView1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button showButton2;
        private System.Windows.Forms.Button updateButton4;
        private System.Windows.Forms.Button deleteButton5;
        private System.Windows.Forms.Button searchButton6;
    }
}