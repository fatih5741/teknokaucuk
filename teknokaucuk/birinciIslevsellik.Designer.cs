
namespace teknokaucuk
{
    partial class birinciIslevsellik
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
            this.textBox_birincisayi = new System.Windows.Forms.TextBox();
            this.textBox_ikincisayi = new System.Windows.Forms.TextBox();
            this.textBox_ucuncusayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_sonuc = new System.Windows.Forms.Button();
            this.textBox_sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_birincisayi
            // 
            this.textBox_birincisayi.Location = new System.Drawing.Point(83, 16);
            this.textBox_birincisayi.Name = "textBox_birincisayi";
            this.textBox_birincisayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_birincisayi.TabIndex = 0;
            // 
            // textBox_ikincisayi
            // 
            this.textBox_ikincisayi.Location = new System.Drawing.Point(83, 41);
            this.textBox_ikincisayi.Name = "textBox_ikincisayi";
            this.textBox_ikincisayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_ikincisayi.TabIndex = 1;
            // 
            // textBox_ucuncusayi
            // 
            this.textBox_ucuncusayi.Location = new System.Drawing.Point(83, 67);
            this.textBox_ucuncusayi.Name = "textBox_ucuncusayi";
            this.textBox_ucuncusayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_ucuncusayi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Sayı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Sayı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3. Sayı: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "SONUÇ: ";
            // 
            // button_sonuc
            // 
            this.button_sonuc.Location = new System.Drawing.Point(72, 102);
            this.button_sonuc.Name = "button_sonuc";
            this.button_sonuc.Size = new System.Drawing.Size(129, 23);
            this.button_sonuc.TabIndex = 7;
            this.button_sonuc.Text = "SONUCU GÖSTER";
            this.button_sonuc.UseVisualStyleBackColor = true;
            this.button_sonuc.Click += new System.EventHandler(this.button_sonuc_Click);
            // 
            // textBox_sonuc
            // 
            this.textBox_sonuc.Location = new System.Drawing.Point(83, 138);
            this.textBox_sonuc.Name = "textBox_sonuc";
            this.textBox_sonuc.Size = new System.Drawing.Size(100, 20);
            this.textBox_sonuc.TabIndex = 8;
            // 
            // birinciIslevsellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 181);
            this.Controls.Add(this.textBox_sonuc);
            this.Controls.Add(this.button_sonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ucuncusayi);
            this.Controls.Add(this.textBox_ikincisayi);
            this.Controls.Add(this.textBox_birincisayi);
            this.Name = "birinciIslevsellik";
            this.Text = "1. İslevsellik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_birincisayi;
        private System.Windows.Forms.TextBox textBox_ikincisayi;
        private System.Windows.Forms.TextBox textBox_ucuncusayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_sonuc;
        private System.Windows.Forms.TextBox textBox_sonuc;
    }
}