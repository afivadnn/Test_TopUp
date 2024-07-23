using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topup;

namespace Topup
{
    public partial class Form1 : Form
    {
        private TopUpData topUpData = new TopUpData();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topUpData.Game = "Free Fire";
            OpenForm2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            topUpData.Game = "Free Fire";
            OpenForm2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topUpData.Game = "Mobile Legends";
            OpenForm3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topUpData.Game = "PUBG";
            OpenForm4();
        }

        private void OpenForm2()
        {
            Form2 form2 = new Form2(topUpData);
            form2.Show();
            this.Hide();
        }

        private void OpenForm3()
        {
            Form3 form3 = new Form3(topUpData);
            form3.Show();
            this.Hide();
        }

        private void OpenForm4()
        {
            Form4 form4 = new Form4(topUpData);
            form4.Show();
            this.Hide();
        }
    }
}
