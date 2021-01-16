
namespace teknokaucuk
{
    partial class ucuncuIslevsellik
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
            this.button_calistir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sayi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_calistir
            // 
            this.button_calistir.Location = new System.Drawing.Point(80, 81);
            this.button_calistir.Name = "button_calistir";
            this.button_calistir.Size = new System.Drawing.Size(75, 23);
            this.button_calistir.TabIndex = 0;
            this.button_calistir.Text = "Çalıştır";
            this.button_calistir.UseVisualStyleBackColor = true;
            this.button_calistir.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen 1 ile 15 Arasında Bir Sayı Giriniz.";
            // 
            // textBox_sayi
            // 
            this.textBox_sayi.Location = new System.Drawing.Point(68, 55);
            this.textBox_sayi.Name = "textBox_sayi";
            this.textBox_sayi.Size = new System.Drawing.Size(100, 20);
            this.textBox_sayi.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 212);
            this.listBox1.TabIndex = 3;
            // 
            // ucuncuIslevsellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_sayi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_calistir);
            this.Name = "ucuncuIslevsellik";
            this.Text = "3. İşlevsellik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sayi;
        private System.Windows.Forms.ListBox listBox1;
    }
}