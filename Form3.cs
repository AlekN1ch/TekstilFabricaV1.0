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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static decimal nabZatr;
        public void Zatrati()
        {
            decimal zatratiHl =(numericUpDown1.Value * Form4.Tkan1Hl + numericUpDown2.Value * Form4.Tkan2Hl + numericUpDown3.Value * Form4.Tkan3Hl);
            label6.Text = zatratiHl.ToString();
             nabZatr = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value);
            label5.Text = nabZatr.ToString();
            decimal ostHl= (Form2.hlopok-zatratiHl);
            decimal ostNab=(Form2.nabor - nabZatr);
            if (ostHl < 0 || ostNab < 0)
            {
                MessageBox.Show("Затраты превышают имеющиеся ресурсы"); numericUpDown1.Value = 0; numericUpDown2.Value = 0; numericUpDown3.Value = 0;
            }
            else label8.Text = ostHl.ToString(); label9.Text = ostNab.ToString();Form2.hlopok -= Convert.ToInt32(zatratiHl); Form2.nabor -= Convert.ToInt32(nabZatr);
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Zatrati();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Zatrati();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Zatrati();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
