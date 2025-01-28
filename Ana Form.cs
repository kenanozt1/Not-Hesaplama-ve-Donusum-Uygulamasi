using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üniversite_Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVizeFinalOrt_Click(object sender, EventArgs e)
        {
            Vize_Final_Ortalama_Hesaplama form2 = new Vize_Final_Ortalama_Hesaplama();
            form2.Show();
        }

        private void btnVizeİleFinalBulma_Click(object sender, EventArgs e)
        {
            Vize_ile_Final_Bulma form3 = new Vize_ile_Final_Bulma();
            form3.Show();
        }

        private void btnSeneSonuOrt_Click(object sender, EventArgs e)
        {
            Sene_Sonu_Genel_Ortalama form4 = new Sene_Sonu_Genel_Ortalama();
            form4.Show();
        }

        private void btnsayiçevirme_Click(object sender, EventArgs e)
        {
            Onluk_ve_İkilik_Çevirme form5 = new Onluk_ve_İkilik_Çevirme();
            form5.Show();
        }
    }
}
