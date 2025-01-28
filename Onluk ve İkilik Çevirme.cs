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
    public partial class Onluk_ve_İkilik_Çevirme : Form
    {
        public Onluk_ve_İkilik_Çevirme()
        {
            InitializeComponent();
        }

        private void btnhesapla_ikilik_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(txtsayi.Text);
                int kalan;
                string yazikalan = "";

                while (sayi != 0)
                {
                    kalan = sayi % 2;
                    sayi = sayi / 2;

                    yazikalan = kalan.ToString() + yazikalan;
                }
                listsonuc.Items.Add(
                    "Onluk sayı :" + txtsayi.Text + " => İkilik sayı :" + yazikalan);
            }
            catch
            {
                MessageBox.Show("Sayı Girişi Yapınız", "HATA");
            }
        }

        private void btnhesapla_onluk_Click(object sender, EventArgs e)
        {
            try
            {
                string sayi = txtsayi.Text;

                int dec = 0;
                for (int i = 0; i < sayi.Length; i++)
                {
                    if (sayi[sayi.Length - i - 1] == '0') continue;
                    dec += (int)Math.Pow(2, i);
                }
                listsonuc.Items.Add(
                    "İkilik sayı :" + txtsayi.Text + " => Onluk sayı :" + dec);
            }
            catch
            {
                MessageBox.Show("Sayı Girişi Yapınız", "HATA");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listsonuc.Items.Clear();
            txtsayi.Clear();
        }
    }
}
