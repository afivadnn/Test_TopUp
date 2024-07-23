using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topup
{
    public partial class Form3 : Form
    {
        private TopUpData topUpData;
        public Form3(TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 13000;
            OpenForm5();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 21000;
            OpenForm5();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 28000;
            OpenForm5();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 29000;
            OpenForm5();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 38000;
            OpenForm5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 43000;
            OpenForm5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 65000;
            OpenForm5();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 81000;
            OpenForm5();
        }

        private void OpenForm5()
        {
            topUpData.UserId = idml.Text;
            topUpData.Server = sever.Text;
            Form5 form5 = new Form5(topUpData);
            form5.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
