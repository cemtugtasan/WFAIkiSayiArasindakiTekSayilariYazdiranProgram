using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAikiSayiArasındakiTekSayılarıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int sayi1 = 0;
        int sayi2 = 0;

        private void btnGöster_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            if ((sayi1) % 2 == 0)
            {
                sayi1++;
            
            
            


            }
            for (int i = sayi1; i <= sayi2; i+=2)
            {
                lblSonuc.Text += " "+ i.ToString();
            }
        }


        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSayi2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
