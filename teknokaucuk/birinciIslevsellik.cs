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
    public partial class birinciIslevsellik : Form
    {
        public birinciIslevsellik()
        {
            InitializeComponent();
        }
        int sayi1, sayi2, sayi3, sonuc;
        private void button_sonuc_Click(object sender, EventArgs e)
        {
            sayi1 =Convert.ToInt32 (textBox_birincisayi.Text);
            sayi2 = Convert.ToInt32(textBox_ikincisayi.Text);
            sayi3 = Convert.ToInt32(textBox_ucuncusayi.Text);

            sonuc = (sayi1 + sayi2) * sayi3;

            textBox_sonuc.Text = sonuc.ToString();


        }
    }
}
