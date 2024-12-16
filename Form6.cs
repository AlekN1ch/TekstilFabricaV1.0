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
    public partial class Form6 : Form
    {
        public int num=0;
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Check()
        {
            switch (num)
            { 
                case 0:
                    label2.BackColor = Color.IndianRed;
                    label3.BackColor = Color.IndianRed;
                    label5.BackColor = Color.IndianRed;
                    label4.BackColor = Color.IndianRed;
                    break;
                case 1:
                    label2.BackColor = SystemColors.Info;
                    label3.BackColor = Color.IndianRed;
                    label5.BackColor = Color.IndianRed;
                    label4.BackColor = Color.IndianRed;
                    break;
                case 2:
                    label3.BackColor = SystemColors.Info;
                    label2.BackColor = Color.IndianRed;
                    label5.BackColor = Color.IndianRed;
                    label4.BackColor = Color.IndianRed;
                    break;
                case 3:
                    label5.BackColor = SystemColors.Info;
                    label3.BackColor = Color.IndianRed;
                    label2.BackColor = Color.IndianRed;
                    label4.BackColor = Color.IndianRed;
                    break;
                case 4:
                    label4.BackColor = SystemColors.Info;
                    label3.BackColor = Color.IndianRed;
                    label5.BackColor = Color.IndianRed;
                    label2.BackColor = Color.IndianRed;
                    break;
                    case 5:
                    MessageBox.Show("Все этапы работы завершены");
                    Form2.tkani +=Convert.ToInt32(Form3.nabZatr);
                    num = 0;
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            num++;
            Check();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
