namespace PR3___07__3.het
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
            this.button_ok = new System.Windows.Forms.Button();
            this.lbl_kiiratas = new System.Windows.Forms.Label();
            this.tb_tipp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(141, 62);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "O.K.";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // lbl_kiiratas
            // 
            this.lbl_kiiratas.AutoSize = true;
            this.lbl_kiiratas.Location = new System.Drawing.Point(15, 99);
            this.lbl_kiiratas.Name = "lbl_kiiratas";
            this.lbl_kiiratas.Size = new System.Drawing.Size(10, 13);
            this.lbl_kiiratas.TabIndex = 2;
            this.lbl_kiiratas.Text = "-";
            // 
            // tb_tipp
            // 
            this.tb_tipp.Location = new System.Drawing.Point(18, 62);
            this.tb_tipp.Name = "tb_tipp";
            this.tb_tipp.Size = new System.Drawing.Size(100, 20);
            this.tb_tipp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gondoltam egy számra 1-től 50-ig. Melyik az?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tipp);
            this.Controls.Add(this.lbl_kiiratas);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1";
            this.Text = "G";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label lbl_kiiratas;
        private System.Windows.Forms.TextBox tb_tipp;
        private System.Windows.Forms.Label label1;
    }
}

