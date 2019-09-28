namespace Assignment6
{
    partial class itemForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.itemDataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton1 = new System.Windows.Forms.Button();
            this.showButton2 = new System.Windows.Forms.Button();
            this.updateButton3 = new System.Windows.Forms.Button();
            this.deleteButton4 = new System.Windows.Forms.Button();
            this.searchButton5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item ID";
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(141, 58);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(119, 20);
            this.itemIdTextBox.TabIndex = 3;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(141, 110);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(118, 20);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(141, 165);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(119, 20);
            this.itemPriceTextBox.TabIndex = 5;
            // 
            // itemDataGridView1
            // 
            this.itemDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView1.Location = new System.Drawing.Point(306, 31);
            this.itemDataGridView1.Name = "itemDataGridView1";
            this.itemDataGridView1.Size = new System.Drawing.Size(409, 275);
            this.itemDataGridView1.TabIndex = 6;
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(105, 345);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(75, 23);
            this.addButton1.TabIndex = 7;
            this.addButton1.Text = "ADD";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // showButton2
            // 
            this.showButton2.Location = new System.Drawing.Point(209, 345);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(75, 23);
            this.showButton2.TabIndex = 8;
            this.showButton2.Text = "Show";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showButton2_Click);
            // 
            // updateButton3
            // 
            this.updateButton3.Location = new System.Drawing.Point(315, 345);
            this.updateButton3.Name = "updateButton3";
            this.updateButton3.Size = new System.Drawing.Size(75, 23);
            this.updateButton3.TabIndex = 9;
            this.updateButton3.Text = "Update";
            this.updateButton3.UseVisualStyleBackColor = true;
            this.updateButton3.Click += new System.EventHandler(this.updateButton3_Click);
            // 
            // deleteButton4
            // 
            this.deleteButton4.Location = new System.Drawing.Point(416, 345);
            this.deleteButton4.Name = "deleteButton4";
            this.deleteButton4.Size = new System.Drawing.Size(75, 23);
            this.deleteButton4.TabIndex = 10;
            this.deleteButton4.Text = "Delete";
            this.deleteButton4.UseVisualStyleBackColor = true;
            this.deleteButton4.Click += new System.EventHandler(this.deleteButton4_Click);
            // 
            // searchButton5
            // 
            this.searchButton5.Location = new System.Drawing.Point(519, 345);
            this.searchButton5.Name = "searchButton5";
            this.searchButton5.Size = new System.Drawing.Size(75, 23);
            this.searchButton5.TabIndex = 11;
            this.searchButton5.Text = "Search";
            this.searchButton5.UseVisualStyleBackColor = true;
            this.searchButton5.Click += new System.EventHandler(this.searchButton5_Click);
            // 
            // itemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 433);
            this.Controls.Add(this.searchButton5);
            this.Controls.Add(this.deleteButton4);
            this.Controls.Add(this.updateButton3);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.itemDataGridView1);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "itemForm";
            this.Text = "ITEM";
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.DataGridView itemDataGridView1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button showButton2;
        private System.Windows.Forms.Button updateButton3;
        private System.Windows.Forms.Button deleteButton4;
        private System.Windows.Forms.Button searchButton5;
    }
}

