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
    public partial class Sene_Sonu_Genel_Ortalama : Form
    {
        public Sene_Sonu_Genel_Ortalama()
        {
            InitializeComponent();
        }

        private void Sene_Sonu_Genel_Ortalama_Load(object sender, EventArgs e)
        {
            listsonuclar.Items.Add("---SONUÇLAR---");
            for (int i = 1; i < 16; i++)
            {
                comboDersSayisi.Items.Add(i);
            }
        }

        private void comboDersSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(comboDersSayisi.SelectedItem);
            txtekle(secilen);
        }
        private void veriturugoster()
        {
            Label lblTurVize = new Label()
            {
                Top = 15,
                Left=30,
                Text="Vize Notu",
            };
            panelVeriTuru.Controls.Add(lblTurVize);

            Label lblTurfinal = new Label()
            {
                Top = 15,
                Left = 160,
                Text = "Final Notu",
            };
            panelVeriTuru.Controls.Add(lblTurfinal);

            Label lblTurKredi = new Label()
            {
                Top = 15,
                Left = 285,
                Text = "Ders Kredisi",
            };
            panelVeriTuru.Controls.Add(lblTurKredi);
        }
        private void txtekle(int derssayisi)
        {
            panelVeriGiris.Controls.Clear();
            veriturugoster();
            for (int i = 0; i < derssayisi; i++)
            {
                //Label lblsayi = new Label()
                //{
                //    Width = 20,
                //    Top =63 + i * 50,
                //    Left = 4,
                //    Text = (i + 1).ToString(),
                //    Enabled = false,
                //};
                //panelVeriGiris.Controls.Add(lblsayi);
                TextBox txtvize = new TextBox()
                {
                    Top = 20 + i * 50,
                    Left = 25,
                    // Text = "vize " + (i + 1).ToString(),
                    Name = "vize_" + (i + 1).ToString(),
                };
                panelVeriGiris.Controls.Add(txtvize);

                TextBox txtfinal = new TextBox()
                {
                    Top = 20 + i * 50,
                    Left = 150,
                    //Text = "final " + (i + 1).ToString(),
                    Name = "final_" + (i + 1).ToString(),
                };
                panelVeriGiris.Controls.Add(txtfinal);

                TextBox txtkredi = new TextBox()
                {
                    Top = 20 + i * 50,
                    Left = 275,
                    //Text = "kredi " + (i + 1).ToString(),
                    Name = "kredi_" + (i + 1).ToString(),
                };
                panelVeriGiris.Controls.Add(txtkredi);
            }
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double vize = 0, final = 0, kredi = 0, sonuc = 0, kredi_toplam = 0, kredi_harfNotu_carpim = 0, ders_kredisi = 0;
            int a = 0;
            string harfNotu = "";

            double vize_oran = Convert.ToDouble(comboVizeOran.SelectedItem);
            double final_oran = sinavorani(vize_oran);
            foreach (TextBox item in panelVeriGiris.Controls)
            {
                //string aaa = item.Name;
                //MessageBox.Show(aaa);

                if (a == 0)
                {
                    vize = Convert.ToDouble(item.Text);
                    a++;
                }
                else if (a == 1)
                {
                    final = Convert.ToDouble(item.Text);

                    sonuc = vize * vize_oran + final * final_oran;
                    harfNotu = harfnotubul(sonuc); //harf notunu buluyor aa,bb,cc
                    ders_kredisi = harfnotudegeribul(harfNotu); //harf notunun sayısal karşılığını buluyor 4.00,3.50
                    a++;
                }
                else if (a == 2)
                {
                    kredi = Convert.ToDouble(item.Text);
                    kredi_harfNotu_carpim += kredi * ders_kredisi;
                    kredi_toplam += kredi;
                    a = 0;
                }
            }
            sonuc = Math.Round(kredi_harfNotu_carpim / kredi_toplam,2);
            //MessageBox.Show(sonuc.ToString(),"İşlem sonucu");
            listsonuclar.Items.Add("Dönem Ortalaması = "+sonuc);
        }
        private string harfnotubul(double sonuc)
        {
            string harfnotu;
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
            return harfnotu;
        }
        private double harfnotudegeribul(string harfnotu)
        {
            double deger = 0;
            if (harfnotu == "AA" || harfnotu == "aa")
                deger = 4.00;
            else if (harfnotu == "BA" || harfnotu == "ba")
                deger = 3.50;
            else if (harfnotu == "BB" || harfnotu == "bb")
                deger = 3.00;
            else if (harfnotu == "CB" || harfnotu == "cb")
                deger = 2.50;
            else if (harfnotu == "CC" || harfnotu == "cc")
                deger = 2.00;
            else if (harfnotu == "DC" || harfnotu == "dc")
                deger = 1.50;
            else if (harfnotu == "DD" || harfnotu == "dd")
                deger = 1.00;
            else if (harfnotu == "FD" || harfnotu == "fd")
                deger = 0.50;
            else if (harfnotu == "FF" || harfnotu == "ff")
                deger = 0.00;

            return deger;
        }


        private void comboVizeOran_SelectedIndexChanged(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(comboVizeOran.SelectedItem);
            comboFinalOran.Text = sinavorani(vize).ToString();
        }

        private double sinavorani(double v)
        {
            double v_oran = Convert.ToDouble(v);
            double f_oran = 1 - v_oran;
            return f_oran;
        }


    }
}
