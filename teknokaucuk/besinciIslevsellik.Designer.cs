
namespace teknokaucuk
{
    partial class besinciIslevsellik
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
            this.label_sonuc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_calistir
            // 
            this.button_calistir.Location = new System.Drawing.Point(89, 66);
            this.button_calistir.Name = "button_calistir";
            this.button_calistir.Size = new System.Drawing.Size(100, 23);
            this.button_calistir.TabIndex = 0;
            this.button_calistir.Text = "Çalıştır";
            this.button_calistir.UseVisualStyleBackColor = true;
            this.button_calistir.Click += new System.EventHandler(this.button_calistir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayıyı Giriniz : ";
            // 
            // label_sonuc
            // 
            this.label_sonuc.AutoSize = true;
            this.label_sonuc.Location = new System.Drawing.Point(117, 124);
            this.label_sonuc.Name = "label_sonuc";
            this.label_sonuc.Size = new System.Drawing.Size(40, 13);
            this.label_sonuc.TabIndex = 2;
            this.label_sonuc.Text = "-----------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // besinciIslevsellik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 156);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_sonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_calistir);
            this.Name = "besinciIslevsellik";
            this.Text = "5. İşlevsellik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calistir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_sonuc;
        private System.Windows.Forms.TextBox textBox1;
    }
}