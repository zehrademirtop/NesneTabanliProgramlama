namespace Modul3Unite4
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.textBoxSayi = new System.Windows.Forms.TextBox();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "sayı giriniz";
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(322, 179);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(75, 23);
            this.buttonHesapla.TabIndex = 1;
            this.buttonHesapla.Text = "button1";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click_1);
            // 
            // textBoxSayi
            // 
            this.textBoxSayi.Location = new System.Drawing.Point(474, 89);
            this.textBoxSayi.Name = "textBoxSayi";
            this.textBoxSayi.Size = new System.Drawing.Size(100, 22);
            this.textBoxSayi.TabIndex = 2;
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(464, 227);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(44, 16);
            this.labelSonuc.TabIndex = 3;
            this.labelSonuc.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.textBoxSayi);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.TextBox textBoxSayi;
        private System.Windows.Forms.Label labelSonuc;
    }
}

