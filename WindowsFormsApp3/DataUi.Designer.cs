﻿namespace WindowsFormsApp3
{
    partial class DataUi
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
            this.showbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.firstNumbertextBox2 = new System.Windows.Forms.TextBox();
            this.secondNumbertextBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showbutton1
            // 
            this.showbutton1.Location = new System.Drawing.Point(358, 276);
            this.showbutton1.Name = "showbutton1";
            this.showbutton1.Size = new System.Drawing.Size(75, 23);
            this.showbutton1.TabIndex = 0;
            this.showbutton1.Text = "Show";
            this.showbutton1.UseVisualStyleBackColor = true;
            this.showbutton1.Click += new System.EventHandler(this.showbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.showlabel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Number";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(129, 49);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(100, 20);
            this.nametextBox1.TabIndex = 4;
            // 
            // firstNumbertextBox2
            // 
            this.firstNumbertextBox2.Location = new System.Drawing.Point(129, 90);
            this.firstNumbertextBox2.Name = "firstNumbertextBox2";
            this.firstNumbertextBox2.Size = new System.Drawing.Size(100, 20);
            this.firstNumbertextBox2.TabIndex = 5;
            // 
            // secondNumbertextBox3
            // 
            this.secondNumbertextBox3.Location = new System.Drawing.Point(129, 132);
            this.secondNumbertextBox3.Name = "secondNumbertextBox3";
            this.secondNumbertextBox3.Size = new System.Drawing.Size(100, 20);
            this.secondNumbertextBox3.TabIndex = 6;
            // 
            // DataUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.secondNumbertextBox3);
            this.Controls.Add(this.firstNumbertextBox2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbutton1);
            this.Name = "DataUi";
            this.Text = "DataUi";
            this.Load += new System.EventHandler(this.DataUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.TextBox firstNumbertextBox2;
        private System.Windows.Forms.TextBox secondNumbertextBox3;
    }
}