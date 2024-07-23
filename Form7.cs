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
    public partial class Form7 : Form
    {
        private TopUpData topUpData;
        public Form7(TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
            DisplayData();
        }

        private void DisplayData()
        {
            harga.Text = topUpData.Diamond.ToString();
        }

        private void bayar_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(topUpData);
            form8.Show(); 
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Akan Membatalkan Pembayaran??", "Konfirmasi",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               Form1 form1 = new Form1();
               form1.Show();
            }
        }
    }
}
