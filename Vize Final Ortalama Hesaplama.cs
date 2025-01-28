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
    public partial class Vize_Final_Ortalama_Hesaplama : Form
    {
        public Vize_Final_Ortalama_Hesaplama()
        {
            InitializeComponent();
        }

        internal void btnhesapla_Click(object sender, EventArgs e)
        {
            double vize;
            double final;
            double büt=50;
            double sonuc;
            try
            {
                vize = Convert.ToDouble(txtvize.Text);
                final = Convert.ToDouble(txtfinal.Text);
                double vizeoran = Convert.ToDouble(combovizeoran.Text);
                double finaloran = 1 - vizeoran;
                int gecmenotu = Convert.ToInt32(combogecmenotu.Text);

                if (vize < 0 || vize > 100 || final < 0 || final > 100)
                {
                    MessageBox.Show("Notlar 0-100 aralığında olmalıdır", "HATA");
                    return;
                }
                else
                {
                    sonuc = vize * vizeoran + final * finaloran;
                }
                

                if (txtbüt.Text != "")
                {
                    büt = Convert.ToDouble(txtbüt.Text);
                    sonuc = vize * vizeoran + büt * finaloran;
                }


                string harfnotu;
                string gecmebilgi="abc";
                if (sonuc >= 82)
                    harfnotu = "AA";
                else if (sonuc >= 74)
                    harfnotu = "BA";
                else if (sonuc >= 61)
                    harfnotu = "BB";
                else if (sonuc >= 58)
                    harfnotu = "CB";
                else if (sonuc >= 50)
                    harfnotu = "CC";
                else if (sonuc >= 40)
                    harfnotu = "DC";
                else if (sonuc >= 25)
                    harfnotu = "FD";
                else                
                    harfnotu = "FF";
                
                if (harfnotu == "DC")
                {
                    gecmebilgi = "Şartlı Geçer";
                }
                else if (sonuc >= gecmenotu)
                {
                    gecmebilgi = "GEÇTİNİZ";
                }
                else if (sonuc <= gecmenotu)
                {
                    gecmebilgi = "KALDINIZ";
                }

                groupBoxsonuc.Visible = true;

                txtort.Text = sonuc.ToString();
                txtharf.Text = harfnotu;
                txtgecmedurumu.Text = gecmebilgi;

         

            }
            catch
            {
                MessageBox.Show("Eksik Not Girişi Yapıldı!!!", "UYARI");
            }

        
            
        }

        private void combovizeoran_SelectedIndexChanged(object sender, EventArgs e)
        {
            double vizeoran = Convert.ToDouble(combovizeoran.Text);
            combofinaloran.Text = (1 - vizeoran).ToString();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtvize.Clear();
            txtfinal.Clear();
            txtbüt.Clear();
            txtort.Clear();
            txtharf.Clear();
            txtgecmedurumu.Clear();
        }
    }
}