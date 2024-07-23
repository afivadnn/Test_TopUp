using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Topup;

namespace Topup
{
    public partial class Form8 : Form
    {
        private TopUpData topUpData;
        public Form8(TopUpData data)
        {
            InitializeComponent();
            topUpData = data;
            DisplayData();
        }

        
        private void DisplayData()
        {
            CultureInfo culture = new CultureInfo("id-ID");
            ide.Text = topUpData.UserId;
            gme.Text = topUpData.Game;
            meto.Text = topUpData.PaymentMethod;
            hrg.Text=topUpData.Diamond.ToString();
            idr.Text = topUpData.Diamond.ToString("C", culture);
            serv.Text = topUpData.Server;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void gme_Click(object sender, EventArgs e)
        {
          
        }

        private void ide_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
