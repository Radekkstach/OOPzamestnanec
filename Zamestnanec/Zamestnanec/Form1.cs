using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamestnanec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Zamestnanec fero;
        private void button1_Click(object sender, EventArgs e)
        {
            fero = new Zamestnanec(textBox1.Text, textBox2.Text, dateTimePicker1.Value, (int)numericUpDown1.Value);
            label1.Text = fero.Vypis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fero.OdpracjHodiny((int)numericUpDown2.Value);
            label1.Text = fero.Vypis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = fero.Vypis();
        }
    }
}
