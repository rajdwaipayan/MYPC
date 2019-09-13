namespace Dwaipayan
{
    partial class raj
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
            this.nametextBox1 = new System.Windows.Forms.TextBox();
            this.showlabel2 = new System.Windows.Forms.Label();
            this.namelabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbutton1
            // 
            this.showbutton1.Location = new System.Drawing.Point(217, 80);
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
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nametextBox1
            // 
            this.nametextBox1.Location = new System.Drawing.Point(71, 80);
            this.nametextBox1.Name = "nametextBox1";
            this.nametextBox1.Size = new System.Drawing.Size(120, 20);
            this.nametextBox1.TabIndex = 2;
            // 
            // showlabel2
            // 
            this.showlabel2.AutoSize = true;
            this.showlabel2.Location = new System.Drawing.Point(256, 179);
            this.showlabel2.Name = "showlabel2";
            this.showlabel2.Size = new System.Drawing.Size(0, 13);
            this.showlabel2.TabIndex = 3;
            // 
            // namelabel2
            // 
            this.namelabel2.AutoSize = true;
            this.namelabel2.Location = new System.Drawing.Point(240, 206);
            this.namelabel2.Name = "namelabel2";
            this.namelabel2.Size = new System.Drawing.Size(0, 13);
            this.namelabel2.TabIndex = 4;
            // 
            // raj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 385);
            this.Controls.Add(this.namelabel2);
            this.Controls.Add(this.showlabel2);
            this.Controls.Add(this.nametextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showbutton1);
            this.KeyPreview = true;
            this.Name = "raj";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.raj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextBox1;
        private System.Windows.Forms.Label showlabel2;
        private System.Windows.Forms.Label namelabel2;
    }
}

