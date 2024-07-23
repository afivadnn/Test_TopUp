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
    public partial class Form9 : Form
    {
        private TopUpData topUpData;
        public Form9(TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
            DisplayData();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  randomCode=RandomCodeGenerator.GenerateRandomCode(6);
            button2.Text = randomCode;
        }

        public static class RandomCodeGenerator
        {
            private static Random random = new Random();

            public static string GenerateRandomCode(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(topUpData);
            form8.Show();
        }

        private void DisplayData()
        {
            harga.Text = topUpData.Diamond.ToString();
        }
        private void harga_Click(object sender, EventArgs e)
        {
           
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
