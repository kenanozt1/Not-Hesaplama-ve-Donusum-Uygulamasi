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
    public partial class Vize_ile_Final_Bulma : Form
    {
        public Vize_ile_Final_Bulma()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double vize = Convert.ToDouble(txtvize.Text);
                double vizeoran = Convert.ToDouble(combovizeoran.Text);
                double finaloran=60;
                int gecmenotu = Convert.ToInt32(combogecmenotu.Text);
                if (vize < 0 || vize > 100)
                {
                    MessageBox.Show("Notlar 0-100 Arası Olmalıdır", "UYARI");
                    return;
                }
                else if (vizeoran == 0.1)
                    finaloran = 90;
                else if (vizeoran == 0.2)
                    finaloran = 80;
                else if (vizeoran == 0.3)
                    finaloran = 70;
                else if (vizeoran == 0.4)
                    finaloran = 60;
                else if (vizeoran == 0.5)
                    finaloran = 50;
                else if (vizeoran == 0.6)
                    finaloran = 40;
                else if (vizeoran == 0.7)
                    finaloran = 30;
                else if (vizeoran == 0.8)
                    finaloran = 20;
                else if (vizeoran == 0.9)
                    finaloran = 10;
                double sonuc = (gecmenotu - vize * vizeoran) * 100 / finaloran;

                lblsonuc.ForeColor = Color.Red;
                lblsonuc.Text = "En Düşük "+(Math.Round(sonuc, 2).ToString())+" Almalısın.";
            }
            catch
            {
                MessageBox.Show("Not Giriniz","UYARI");
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtvize.Clear();
            lblsonuc.Text = "";
        }
    }
}
