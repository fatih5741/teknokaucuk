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
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        birinciIslevsellik birinciislev = new birinciIslevsellik();
        ikinciIslevsellik ikinciislev = new ikinciIslevsellik();
        ucuncuIslevsellik ucuncuislev = new ucuncuIslevsellik();
        besinciIslevsellik besinciislev = new besinciIslevsellik();

        string[] islevsellik = {"1. İşlevsellik", "2. İşlevsellik", "3. İşlevsellik", "4. İşlevsellik", "5. İşlevsellik" };
        private void anaForm_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(islevsellik);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                birinciislev.Show();
            }

            else if (comboBox1.SelectedIndex==1)
            {
                ikinciislev.Show();
            }
            else if (comboBox1.SelectedIndex==2)
            {
                ucuncuislev.Show();
            }
            else if (comboBox1.SelectedIndex==4)
            {
                besinciislev.Show();
            }
        }
    }
}
