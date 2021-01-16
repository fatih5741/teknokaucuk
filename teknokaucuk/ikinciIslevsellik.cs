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
    public partial class ikinciIslevsellik : Form
    {
        public ikinciIslevsellik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                for (int i = 1; i <= 200; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        if (i >= 100)
                        {
                            listBox1.Items.Add("zagzig");
                        }
                        else
                            listBox1.Items.Add("zigzag");

                    }
                    else if (i % 3 == 0)
                    {
                        listBox1.Items.Add("zig");

                    }
                    else if (i % 5 == 0)
                    {
                        listBox1.Items.Add("zag");

                    }

                    else
                    listBox1.Items.Add(i);



            }

                


        }
     
    }
}
