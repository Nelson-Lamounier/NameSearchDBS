namespace NameSearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBoy = new System.Windows.Forms.TextBox();
            this.textBoxGirl = new System.Windows.Forms.TextBox();
            this.labelBoy = new System.Windows.Forms.Label();
            this.labelGirls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 104);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxBoy
            // 
            this.textBoxBoy.Location = new System.Drawing.Point(257, 70);
            this.textBoxBoy.MaximumSize = new System.Drawing.Size(100, 80);
            this.textBoxBoy.MinimumSize = new System.Drawing.Size(100, 31);
            this.textBoxBoy.Name = "textBoxBoy";
            this.textBoxBoy.Size = new System.Drawing.Size(100, 31);
            this.textBoxBoy.TabIndex = 1;
            this.textBoxBoy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGirl
            // 
            this.textBoxGirl.Location = new System.Drawing.Point(257, 142);
            this.textBoxGirl.Name = "textBoxGirl";
            this.textBoxGirl.Size = new System.Drawing.Size(100, 31);
            this.textBoxGirl.TabIndex = 2;
            // 
            // labelBoy
            // 
            this.labelBoy.AutoSize = true;
            this.labelBoy.Location = new System.Drawing.Point(34, 70);
            this.labelBoy.Name = "labelBoy";
            this.labelBoy.Size = new System.Drawing.Size(195, 25);
            this.labelBoy.TabIndex = 3;
            this.labelBoy.Text = "Enter Boy\'s Name: ";
            // 
            // labelGirls
            // 
            this.labelGirls.AutoSize = true;
            this.labelGirls.Location = new System.Drawing.Point(34, 142);
            this.labelGirls.Name = "labelGirls";
            this.labelGirls.Size = new System.Drawing.Size(185, 25);
            this.labelGirls.TabIndex = 4;
            this.labelGirls.Text = "Enter Girl\'s Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 383);
            this.Controls.Add(this.labelGirls);
            this.Controls.Add(this.labelBoy);
            this.Controls.Add(this.textBoxGirl);
            this.Controls.Add(this.textBoxBoy);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Search Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxBoy;
        private System.Windows.Forms.TextBox textBoxGirl;
        private System.Windows.Forms.Label labelBoy;
        private System.Windows.Forms.Label labelGirls;
    }
}

