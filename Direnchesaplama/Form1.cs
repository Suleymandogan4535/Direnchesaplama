using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Direnchesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal direnc1 = nudDirenc1.Value;
            decimal direnc2 = nudDirenc2.Value;
            double sonuc = 0;

            if (cmbBaglanti.Text=="Seri Bağlantı")
            {
                sonuc = Convert.ToDouble(direnc1 + direnc2);   
            }
            else if(cmbBaglanti.Text=="Paralel Bağlantı")
            {
                sonuc =Convert.ToDouble( (direnc1 * direnc2) / ( direnc1 + direnc2 ));
            }

            if(cmbBirim.Text=="Ohm")
            {
                lblSonuc.Text = Convert.ToString(sonuc);
            }
            else if (cmbBirim.Text == "KiloOhm")
            {
                double kosonuc = sonuc / 1000;
                lblSonuc.Text = Convert.ToString(kosonuc);
            }
            else if (cmbBirim.Text == "MegaOhm")
            {
                double mosonuc = sonuc / 1000000;
                lblSonuc.Text = Convert.ToString(mosonuc);
            }


        }
    }
}
