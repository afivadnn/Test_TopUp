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
  
    public partial class Form5 : Form
    {
        private TopUpData topUpData;
        public Form5( TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            topUpData.PaymentMethod = "Alfamart";
            OpenForm9();
        }

        private void Dana_Click(object sender, EventArgs e)
        {
            topUpData.PaymentMethod = "Dana";
            OpenForm6();
        }

        private void Gopay_Click(object sender, EventArgs e)
        {
            topUpData.PaymentMethod = "Gopay";
            OpenForm6();
        }

        private void Bri_Click(object sender, EventArgs e)
        {
            topUpData.PaymentMethod = "Bank BRI";
            OpenForm7();
        }

        private void OpenForm6()
        {
            Form6 form6 = new Form6(topUpData);
            form6.Show();
            this.Hide();
        }

        private void OpenForm7()
        {
            Form7 form7 = new Form7(topUpData);
            form7.Show();
            this.Hide();
        }

        private void OpenForm9()
        {
            Form9 form9 = new Form9(topUpData);
            form9.Show();
            this.Hide();
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
