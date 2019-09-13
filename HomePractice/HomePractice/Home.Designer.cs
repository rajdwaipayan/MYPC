namespace HomePractice
{
    partial class Dwaipayan
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
            this.namelabel1 = new System.Windows.Forms.Label();
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.showlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbutton1
            // 
            this.showbutton1.Location = new System.Drawing.Point(289, 54);
            this.showbutton1.Name = "showbutton1";
            this.showbutton1.Size = new System.Drawing.Size(75, 23);
            this.showbutton1.TabIndex = 0;
            this.showbutton1.Text = "Show";
            this.showbutton1.UseVisualStyleBackColor = true;
            this.showbutton1.Click += new System.EventHandler(this.showbutton1_Click);
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.Location = new System.Drawing.Point(13, 59);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(35, 13);
            this.namelabel1.TabIndex = 1;
            this.namelabel1.Text = "Name";
            this.namelabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(79, 56);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(185, 20);
            this.nametextBox1.TabIndex = 2;
            // 
            // showlabel1
            // 
            this.showlabel1.AutoSize = true;
            this.showlabel1.Location = new System.Drawing.Point(315, 157);
            this.showlabel1.Name = "showlabel1";
            this.showlabel1.Size = new System.Drawing.Size(0, 13);
            this.showlabel1.TabIndex = 3;
            // 
            // Dwaipayan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 371);
            this.Controls.Add(this.showlabel1);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.showbutton1);
            this.Name = "Dwaipayan";
            this.Text = "DWAIPAYAN MANDAL";
            this.Load += new System.EventHandler(this.Dwaipayan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton1;
        private System.Windows.Forms.Label namelabel1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label showlabel1;
    }
}