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
    public partial class besinciIslevsellik : Form
    {
        public besinciIslevsellik()
        {
            InitializeComponent();
        }


        int sayi1 = 0;
        int sayi2 = 1;
        int toplam, girilen;
        private void button_calistir_Click(object sender, EventArgs e)
        {
           
            girilen = Convert.ToInt32(textBox1.Text);


            for (int i = 0; i < girilen - 2; i++)
            {
                toplam = sayi1 + sayi2;
                label_sonuc.Text = toplam.ToString();
                sayi1 = sayi2;
                sayi2 = toplam;
            }
        }
    }
}
