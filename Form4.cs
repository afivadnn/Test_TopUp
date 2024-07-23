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
    public partial class Form4 : Form
    {
        private TopUpData topUpData;
        public Form4(TopUpData data)
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
            topUpData.Diamond = 6000;
            OpenForm5();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 13000;
            OpenForm5();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 24000;
            OpenForm5();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 36000;
            OpenForm5();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 48000;
            OpenForm5();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 64000;
            OpenForm5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 85000;
            OpenForm5();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            topUpData.Diamond = 97000;
            OpenForm5();
        }

        private void OpenForm5()
        {
            topUpData.UserId = idpbg.Text;
            Form5 form5 = new Form5(topUpData);
            form5.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
