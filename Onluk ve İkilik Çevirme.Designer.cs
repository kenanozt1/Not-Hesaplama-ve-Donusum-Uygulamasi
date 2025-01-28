
namespace Üniversite_Not_Hesaplama
{
    partial class Onluk_ve_İkilik_Çevirme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.btnhesapla_ikilik = new System.Windows.Forms.Button();
            this.btnhesapla_onluk = new System.Windows.Forms.Button();
            this.listsonuc = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Giriniz :";
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(102, 30);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 20);
            this.txtsayi.TabIndex = 1;
            // 
            // btnhesapla_ikilik
            // 
            this.btnhesapla_ikilik.Location = new System.Drawing.Point(30, 70);
            this.btnhesapla_ikilik.Name = "btnhesapla_ikilik";
            this.btnhesapla_ikilik.Size = new System.Drawing.Size(104, 53);
            this.btnhesapla_ikilik.TabIndex = 2;
            this.btnhesapla_ikilik.Text = "2\'lik Sayıya Çevirme";
            this.btnhesapla_ikilik.UseVisualStyleBackColor = true;
            this.btnhesapla_ikilik.Click += new System.EventHandler(this.btnhesapla_ikilik_Click);
            // 
            // btnhesapla_onluk
            // 
            this.btnhesapla_onluk.Location = new System.Drawing.Point(155, 70);
            this.btnhesapla_onluk.Name = "btnhesapla_onluk";
            this.btnhesapla_onluk.Size = new System.Drawing.Size(104, 53);
            this.btnhesapla_onluk.TabIndex = 3;
            this.btnhesapla_onluk.Text = "10\'luk Sayıya Çevirme";
            this.btnhesapla_onluk.UseVisualStyleBackColor = true;
            this.btnhesapla_onluk.Click += new System.EventHandler(this.btnhesapla_onluk_Click);
            // 
            // listsonuc
            // 
            this.listsonuc.FormattingEnabled = true;
            this.listsonuc.Location = new System.Drawing.Point(12, 143);
            this.listsonuc.Name = "listsonuc";
            this.listsonuc.Size = new System.Drawing.Size(264, 160);
            this.listsonuc.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTemizle.Location = new System.Drawing.Point(10, 309);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(266, 31);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Onluk_ve_İkilik_Çevirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 347);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listsonuc);
            this.Controls.Add(this.btnhesapla_onluk);
            this.Controls.Add(this.btnhesapla_ikilik);
            this.Controls.Add(this.txtsayi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Onluk_ve_İkilik_Çevirme";
            this.Text = "Onluk & İkilik Sayı Çevirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Button btnhesapla_ikilik;
        private System.Windows.Forms.Button btnhesapla_onluk;
        private System.Windows.Forms.ListBox listsonuc;
        private System.Windows.Forms.Button btnTemizle;
    }
}