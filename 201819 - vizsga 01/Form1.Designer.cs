namespace _201819___vizsga_01
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
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label_nev = new System.Windows.Forms.Label();
            this.radioButton_kutya = new System.Windows.Forms.RadioButton();
            this.radioButton_macska = new System.Windows.Forms.RadioButton();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_output = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(12, 37);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(160, 20);
            this.textBox_nev.TabIndex = 0;
            this.textBox_nev.TextChanged += new System.EventHandler(this.textBox_nev_TextChanged);
            // 
            // label_nev
            // 
            this.label_nev.AutoSize = true;
            this.label_nev.Location = new System.Drawing.Point(12, 21);
            this.label_nev.Name = "label_nev";
            this.label_nev.Size = new System.Drawing.Size(30, 13);
            this.label_nev.TabIndex = 1;
            this.label_nev.Text = "Név:";
            // 
            // radioButton_kutya
            // 
            this.radioButton_kutya.AutoSize = true;
            this.radioButton_kutya.Checked = true;
            this.radioButton_kutya.Location = new System.Drawing.Point(15, 63);
            this.radioButton_kutya.Name = "radioButton_kutya";
            this.radioButton_kutya.Size = new System.Drawing.Size(52, 17);
            this.radioButton_kutya.TabIndex = 2;
            this.radioButton_kutya.TabStop = true;
            this.radioButton_kutya.Text = "Kutya";
            this.radioButton_kutya.UseVisualStyleBackColor = true;
            // 
            // radioButton_macska
            // 
            this.radioButton_macska.AutoSize = true;
            this.radioButton_macska.Location = new System.Drawing.Point(106, 63);
            this.radioButton_macska.Name = "radioButton_macska";
            this.radioButton_macska.Size = new System.Drawing.Size(63, 17);
            this.radioButton_macska.TabIndex = 3;
            this.radioButton_macska.Text = "Macska";
            this.radioButton_macska.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Location = new System.Drawing.Point(15, 86);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(157, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Hozzáadás a listához";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Enabled = false;
            this.button_remove.Location = new System.Drawing.Point(15, 115);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(157, 23);
            this.button_remove.TabIndex = 5;
            this.button_remove.Text = "Kijelölt törlése a listából";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(178, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(115, 121);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.Location = new System.Drawing.Point(299, 129);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(35, 13);
            this.label_output.TabIndex = 9;
            this.label_output.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 152);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.radioButton_macska);
            this.Controls.Add(this.radioButton_kutya);
            this.Controls.Add(this.label_nev);
            this.Controls.Add(this.textBox_nev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label_nev;
        private System.Windows.Forms.RadioButton radioButton_kutya;
        private System.Windows.Forms.RadioButton radioButton_macska;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_output;
    }
}

