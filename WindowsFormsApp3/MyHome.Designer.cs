namespace WindowsFormsApp3
{
    partial class MyHome
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
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.showbutton1 = new System.Windows.Forms.Button();
            this.showlabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.showbutton1_Click);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(110, 54);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(100, 20);
            this.nametextBox1.TabIndex = 1;
            // 
            // showbutton1
            // 
            this.showbutton1.Location = new System.Drawing.Point(243, 57);
            this.showbutton1.Name = "showbutton1";
            this.showbutton1.Size = new System.Drawing.Size(75, 23);
            this.showbutton1.TabIndex = 2;
            this.showbutton1.Text = "Show";
            this.showbutton1.UseVisualStyleBackColor = true;
            this.showbutton1.Click += new System.EventHandler(this.showbutton1_Click);
            // 
            // showlabel2
            // 
            this.showlabel2.AutoSize = true;
            this.showlabel2.Location = new System.Drawing.Point(487, 172);
            this.showlabel2.Name = "showlabel2";
            this.showlabel2.Size = new System.Drawing.Size(0, 13);
            this.showlabel2.TabIndex = 3;
            // 
            // MyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showlabel2);
            this.Controls.Add(this.showbutton1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label1);
            this.Name = "MyHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Button showbutton1;
        private System.Windows.Forms.Label showlabel2;
    }
}

