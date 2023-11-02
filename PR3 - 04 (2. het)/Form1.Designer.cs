namespace PR3___04__2.het_
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
            this.lbl01_output = new System.Windows.Forms.Label();
            this.button1_sorsolas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl01_output
            // 
            this.lbl01_output.AutoSize = true;
            this.lbl01_output.Location = new System.Drawing.Point(12, 9);
            this.lbl01_output.Name = "lbl01_output";
            this.lbl01_output.Size = new System.Drawing.Size(0, 13);
            this.lbl01_output.TabIndex = 0;
            // 
            // button1_sorsolas
            // 
            this.button1_sorsolas.Location = new System.Drawing.Point(64, 74);
            this.button1_sorsolas.Name = "button1_sorsolas";
            this.button1_sorsolas.Size = new System.Drawing.Size(75, 23);
            this.button1_sorsolas.TabIndex = 1;
            this.button1_sorsolas.Text = "Sorsolás";
            this.button1_sorsolas.UseVisualStyleBackColor = true;
            this.button1_sorsolas.Click += new System.EventHandler(this.button1_sorsolas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 116);
            this.Controls.Add(this.button1_sorsolas);
            this.Controls.Add(this.lbl01_output);
            this.Name = "Form1";
            this.Text = "Lottószámok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl01_output;
        private System.Windows.Forms.Button button1_sorsolas;
    }
}

