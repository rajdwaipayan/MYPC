namespace WindowsFormsApp3
{
    partial class ConditionUi
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
            this.showButton1 = new System.Windows.Forms.Button();
            this.itemcomboBox1 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // showButton1
            // 
            this.showButton1.Location = new System.Drawing.Point(235, 48);
            this.showButton1.Name = "showButton1";
            this.showButton1.Size = new System.Drawing.Size(75, 23);
            this.showButton1.TabIndex = 0;
            this.showButton1.Text = "Show";
            this.showButton1.UseVisualStyleBackColor = true;
            this.showButton1.Click += new System.EventHandler(this.showButton1_Click);
            // 
            // itemcomboBox1
            // 
            this.itemcomboBox1.FormattingEnabled = true;
            this.itemcomboBox1.Items.AddRange(new object[] {
            "Pen",
            "Pencil",
            "Rubber"});
            this.itemcomboBox1.Location = new System.Drawing.Point(90, 50);
            this.itemcomboBox1.Name = "itemcomboBox1";
            this.itemcomboBox1.Size = new System.Drawing.Size(121, 21);
            this.itemcomboBox1.TabIndex = 1;
            this.itemcomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(474, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 191);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // ConditionUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.itemcomboBox1);
            this.Controls.Add(this.showButton1);
            this.Name = "ConditionUi";
            this.Text = "ConditionUi";
            this.Load += new System.EventHandler(this.ConditionUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showButton1;
        private System.Windows.Forms.ComboBox itemcomboBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}