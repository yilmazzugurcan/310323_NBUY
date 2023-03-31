using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _310323_NBUY
{
    public partial class Kronometre : Form
    {

        public Kronometre()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }
        int sayac = 0;
        int dakika = 0;
        int saat = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (label1.Text == "60")
            {
                dakika++;
                label2.Text= dakika.ToString();
                sayac = 0;
            }
             if (label2.Text=="60")
            {
                dakika = 0;
                label2.Text = dakika.ToString();
                saat++;
                label3.Text = saat.ToString();

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 0;
            dakika = 0;
            saat = 0;
            label1.Text = sayac.ToString();
            label2.Text = dakika.ToString();
            label3.Text = saat.ToString();
        }
    }
}
