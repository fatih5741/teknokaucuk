using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teknokaucuk
{
    public partial class ucuncuIslevsellik : Form
    {
        public ucuncuIslevsellik()
        {
            InitializeComponent();
        }
        int sayi,sonuc;
        
        private void button1_Click(object sender, EventArgs e)
        {

            sayi = Convert.ToInt32(textBox_sayi.Text);

            if (sayi > 15)
            {
                MessageBox.Show("LÜtfen 1 ile 15 arasında bir sayı giriniz.");
            }

            else
            {
                string atla = " ";

                for (int i = 1; i < sayi+1; i++)
                {
                    for (int x = 1; x < sayi+1; x++)
                    {
                        sonuc = i * x;

                        atla = atla + " " + sonuc;

                    }
                    
                    
                    listBox1.Items.Add(atla);

                    atla = " ";
                }

            }
        }
    }
}
