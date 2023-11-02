namespace PR3___C_SHARP__2_projekt_
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
            this.button3_fibonacci = new System.Windows.Forms.Button();
            this.button2_paratlan = new System.Windows.Forms.Button();
            this.button1_paros = new System.Windows.Forms.Button();
            this.lbl01_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3_fibonacci
            // 
            this.button3_fibonacci.Location = new System.Drawing.Point(189, 35);
            this.button3_fibonacci.Name = "button3_fibonacci";
            this.button3_fibonacci.Size = new System.Drawing.Size(75, 23);
            this.button3_fibonacci.TabIndex = 5;
            this.button3_fibonacci.Text = "Fibonacci";
            this.button3_fibonacci.UseVisualStyleBackColor = true;
            this.button3_fibonacci.Click += new System.EventHandler(this.button3_fibonacci_Click);
            // 
            // button2_paratlan
            // 
            this.button2_paratlan.Location = new System.Drawing.Point(108, 35);
            this.button2_paratlan.Name = "button2_paratlan";
            this.button2_paratlan.Size = new System.Drawing.Size(75, 23);
            this.button2_paratlan.TabIndex = 4;
            this.button2_paratlan.Text = "Páratlan";
            this.button2_paratlan.UseVisualStyleBackColor = true;
            this.button2_paratlan.Click += new System.EventHandler(this.button2_paratlan_Click);
            // 
            // button1_paros
            // 
            this.button1_paros.Location = new System.Drawing.Point(27, 35);
            this.button1_paros.Name = "button1_paros";
            this.button1_paros.Size = new System.Drawing.Size(75, 23);
            this.button1_paros.TabIndex = 3;
            this.button1_paros.Text = "Páros";
            this.button1_paros.UseVisualStyleBackColor = true;
            this.button1_paros.Click += new System.EventHandler(this.button1_paros_Click);
            // 
            // lbl01_output
            // 
            this.lbl01_output.AutoSize = true;
            this.lbl01_output.Location = new System.Drawing.Point(24, 112);
            this.lbl01_output.Name = "lbl01_output";
            this.lbl01_output.Size = new System.Drawing.Size(0, 13);
            this.lbl01_output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 183);
            this.Controls.Add(this.lbl01_output);
            this.Controls.Add(this.button3_fibonacci);
            this.Controls.Add(this.button2_paratlan);
            this.Controls.Add(this.button1_paros);
            this.Name = "Form1";
            this.Text = "Számok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3_fibonacci;
        private System.Windows.Forms.Button button2_paratlan;
        private System.Windows.Forms.Button button1_paros;
        private System.Windows.Forms.Label lbl01_output;
    }
}

