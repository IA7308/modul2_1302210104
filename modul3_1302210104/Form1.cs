using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302210104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int bil1, bil2, jml;
        private void button3_Click(object sender, EventArgs e)
        {
            string bil = "0";
            
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bil = "1";
            
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bil = "2";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string bil = "3";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bil = "4";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bil = "5";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string bil = "6";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string bil = "7";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string bil = "8";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string bil = "9";
            OutputBox.Text = OutputBox.Text + bil;
        }

        private void PlusBut_Click(object sender, EventArgs e)
        {
            
            bil1 = Int32.Parse(OutputBox.Text);
            
            OutputBox.Text = "";

        }

        private void EqualsButt_Click(object sender, EventArgs e)
        {
            bil2 = Int32.Parse(OutputBox.Text);

            jml = bil2 + bil1;
            OutputBox.Text = jml.ToString();
        }
    }
}
