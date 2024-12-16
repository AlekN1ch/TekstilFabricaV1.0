using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekstilFabrica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int hlopok = 100, niti = 0, tkani = 0, nabor = 100;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text+=hlopok.ToString();
            label3.Text += niti.ToString();
            label4.Text += tkani.ToString();
            label5.Text +=nabor.ToString();
        }
    }
}
