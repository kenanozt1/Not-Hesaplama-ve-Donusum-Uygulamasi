
namespace Üniversite_Not_Hesaplama
{
    partial class Sene_Sonu_Genel_Ortalama
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
            this.panelVeriGiris = new System.Windows.Forms.Panel();
            this.panelcalistir = new System.Windows.Forms.Panel();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.comboFinalOran = new System.Windows.Forms.ComboBox();
            this.comboVizeOran = new System.Windows.Forms.ComboBox();
            this.comboDersSayisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelVeriTuru = new System.Windows.Forms.Panel();
            this.listsonuclar = new System.Windows.Forms.ListBox();
            this.panelcalistir.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVeriGiris
            // 
            this.panelVeriGiris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelVeriGiris.AutoScroll = true;
            this.panelVeriGiris.Location = new System.Drawing.Point(1, 30);
            this.panelVeriGiris.Name = "panelVeriGiris";
            this.panelVeriGiris.Size = new System.Drawing.Size(429, 328);
            this.panelVeriGiris.TabIndex = 0;
            // 
            // panelcalistir
            // 
            this.panelcalistir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcalistir.Controls.Add(this.btnhesapla);
            this.panelcalistir.Controls.Add(this.comboFinalOran);
            this.panelcalistir.Controls.Add(this.comboVizeOran);
            this.panelcalistir.Controls.Add(this.comboDersSayisi);
            this.panelcalistir.Controls.Add(this.label3);
            this.panelcalistir.Controls.Add(this.label2);
            this.panelcalistir.Controls.Add(this.label1);
            this.panelcalistir.Location = new System.Drawing.Point(429, 0);
            this.panelcalistir.Name = "panelcalistir";
            this.panelcalistir.Size = new System.Drawing.Size(227, 150);
            this.panelcalistir.TabIndex = 1;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhesapla.Location = new System.Drawing.Point(14, 104);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(198, 34);
            this.btnhesapla.TabIndex = 2;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // comboFinalOran
            // 
            this.comboFinalOran.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFinalOran.Enabled = false;
            this.comboFinalOran.FormattingEnabled = true;
            this.comboFinalOran.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9"});
            this.comboFinalOran.Location = new System.Drawing.Point(96, 66);
            this.comboFinalOran.Name = "comboFinalOran";
            this.comboFinalOran.Size = new System.Drawing.Size(116, 21);
            this.comboFinalOran.TabIndex = 1;
            this.comboFinalOran.Text = "0,6";
            // 
            // comboVizeOran
            // 
            this.comboVizeOran.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboVizeOran.FormattingEnabled = true;
            this.comboVizeOran.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9"});
            this.comboVizeOran.Location = new System.Drawing.Point(96, 39);
            this.comboVizeOran.Name = "comboVizeOran";
            this.comboVizeOran.Size = new System.Drawing.Size(116, 21);
            this.comboVizeOran.TabIndex = 1;
            this.comboVizeOran.Text = "0,4";
            this.comboVizeOran.SelectedIndexChanged += new System.EventHandler(this.comboVizeOran_SelectedIndexChanged);
            // 
            // comboDersSayisi
            // 
            this.comboDersSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDersSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDersSayisi.FormattingEnabled = true;
            this.comboDersSayisi.Location = new System.Drawing.Point(96, 12);
            this.comboDersSayisi.Name = "comboDersSayisi";
            this.comboDersSayisi.Size = new System.Drawing.Size(116, 21);
            this.comboDersSayisi.TabIndex = 1;
            this.comboDersSayisi.SelectedIndexChanged += new System.EventHandler(this.comboDersSayisi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Final Oran :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vize Oran";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Sayısı :";
            // 
            // panelVeriTuru
            // 
            this.panelVeriTuru.Location = new System.Drawing.Point(1, 0);
            this.panelVeriTuru.Name = "panelVeriTuru";
            this.panelVeriTuru.Size = new System.Drawing.Size(429, 30);
            this.panelVeriTuru.TabIndex = 0;
            // 
            // listsonuclar
            // 
            this.listsonuclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listsonuclar.FormattingEnabled = true;
            this.listsonuclar.Location = new System.Drawing.Point(429, 147);
            this.listsonuclar.Name = "listsonuclar";
            this.listsonuclar.Size = new System.Drawing.Size(227, 212);
            this.listsonuclar.TabIndex = 2;
            // 
            // Sene_Sonu_Genel_Ortalama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 358);
            this.Controls.Add(this.listsonuclar);
            this.Controls.Add(this.panelVeriTuru);
            this.Controls.Add(this.panelcalistir);
            this.Controls.Add(this.panelVeriGiris);
            this.Name = "Sene_Sonu_Genel_Ortalama";
            this.Text = "Sene Sonu Genel Ortalama";
            this.Load += new System.EventHandler(this.Sene_Sonu_Genel_Ortalama_Load);
            this.panelcalistir.ResumeLayout(false);
            this.panelcalistir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVeriGiris;
        private System.Windows.Forms.Panel panelcalistir;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.ComboBox comboFinalOran;
        private System.Windows.Forms.ComboBox comboVizeOran;
        private System.Windows.Forms.ComboBox comboDersSayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelVeriTuru;
        private System.Windows.Forms.ListBox listsonuclar;
    }
}