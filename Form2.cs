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
    public partial class Form2 : Form
    {
        private TopUpData topUpData;
        public Form2(TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void idff_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 6000;
            OpenForm5();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 6000;
            OpenForm5();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 16000;
            OpenForm5();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 18000;
            OpenForm5();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 19000;
            OpenForm5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 20000;
            OpenForm5();
        }

        private void label19_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 49000;
            OpenForm5();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 55000;
            OpenForm5();
        }

        private void OpenForm5()
        {
            topUpData.UserId = idff.Text;
            Form5 form5 = new Form5(topUpData);
            form5.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void idff_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
