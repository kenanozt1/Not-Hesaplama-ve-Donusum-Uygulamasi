
namespace Üniversite_Not_Hesaplama
{
    partial class Vize_Final_Ortalama_Hesaplama
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
            this.txtvize = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtbüt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbutunleme = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.combovizeoran = new System.Windows.Forms.ComboBox();
            this.combofinaloran = new System.Windows.Forms.ComboBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.combogecmenotu = new System.Windows.Forms.ComboBox();
            this.lblort = new System.Windows.Forms.Label();
            this.lblharfnotu = new System.Windows.Forms.Label();
            this.lblgecmedurumu = new System.Windows.Forms.Label();
            this.txtort = new System.Windows.Forms.TextBox();
            this.txtharf = new System.Windows.Forms.TextBox();
            this.txtgecmedurumu = new System.Windows.Forms.TextBox();
            this.groupBoxsonuc = new System.Windows.Forms.GroupBox();
            this.groupBoxsonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(107, 15);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(100, 20);
            this.txtvize.TabIndex = 0;
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(107, 54);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 2;
            // 
            // txtbüt
            // 
            this.txtbüt.Location = new System.Drawing.Point(107, 93);
            this.txtbüt.Name = "txtbüt";
            this.txtbüt.Size = new System.Drawing.Size(100, 20);
            this.txtbüt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vİze :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final :";
            // 
            // lblbutunleme
            // 
            this.lblbutunleme.AutoSize = true;
            this.lblbutunleme.Location = new System.Drawing.Point(21, 97);
            this.lblbutunleme.Name = "lblbutunleme";
            this.lblbutunleme.Size = new System.Drawing.Size(66, 13);
            this.lblbutunleme.TabIndex = 1;
            this.lblbutunleme.Text = "Bütünleme  :";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.Lime;
            this.btnhesapla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(24, 138);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(257, 32);
            this.btnhesapla.TabIndex = 5;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // combovizeoran
            // 
            this.combovizeoran.FormattingEnabled = true;
            this.combovizeoran.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9"});
            this.combovizeoran.Location = new System.Drawing.Point(240, 15);
            this.combovizeoran.Name = "combovizeoran";
            this.combovizeoran.Size = new System.Drawing.Size(41, 21);
            this.combovizeoran.TabIndex = 1;
            this.combovizeoran.Text = "0,4";
            this.combovizeoran.SelectedIndexChanged += new System.EventHandler(this.combovizeoran_SelectedIndexChanged);
            // 
            // combofinaloran
            // 
            this.combofinaloran.Enabled = false;
            this.combofinaloran.FormattingEnabled = true;
            this.combofinaloran.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9"});
            this.combofinaloran.Location = new System.Drawing.Point(240, 54);
            this.combofinaloran.Name = "combofinaloran";
            this.combofinaloran.Size = new System.Drawing.Size(41, 21);
            this.combofinaloran.TabIndex = 3;
            this.combofinaloran.Text = "0,6";
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Red;
            this.btntemizle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(24, 176);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(257, 32);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // combogecmenotu
            // 
            this.combogecmenotu.FormattingEnabled = true;
            this.combogecmenotu.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.combogecmenotu.Location = new System.Drawing.Point(240, 93);
            this.combogecmenotu.Name = "combogecmenotu";
            this.combogecmenotu.Size = new System.Drawing.Size(41, 21);
            this.combogecmenotu.TabIndex = 8;
            this.combogecmenotu.Text = "50";
            // 
            // lblort
            // 
            this.lblort.AutoSize = true;
            this.lblort.Location = new System.Drawing.Point(22, 16);
            this.lblort.Name = "lblort";
            this.lblort.Size = new System.Drawing.Size(55, 13);
            this.lblort.TabIndex = 10;
            this.lblort.Text = "Ortalama :";
            // 
            // lblharfnotu
            // 
            this.lblharfnotu.AutoSize = true;
            this.lblharfnotu.Location = new System.Drawing.Point(22, 50);
            this.lblharfnotu.Name = "lblharfnotu";
            this.lblharfnotu.Size = new System.Drawing.Size(59, 13);
            this.lblharfnotu.TabIndex = 10;
            this.lblharfnotu.Text = "Harf Notu :";
            // 
            // lblgecmedurumu
            // 
            this.lblgecmedurumu.AutoSize = true;
            this.lblgecmedurumu.Location = new System.Drawing.Point(22, 83);
            this.lblgecmedurumu.Name = "lblgecmedurumu";
            this.lblgecmedurumu.Size = new System.Drawing.Size(87, 13);
            this.lblgecmedurumu.TabIndex = 10;
            this.lblgecmedurumu.Text = "Geçme Durumu :";
            // 
            // txtort
            // 
            this.txtort.Enabled = false;
            this.txtort.Location = new System.Drawing.Point(117, 13);
            this.txtort.Name = "txtort";
            this.txtort.Size = new System.Drawing.Size(100, 20);
            this.txtort.TabIndex = 11;
            // 
            // txtharf
            // 
            this.txtharf.Enabled = false;
            this.txtharf.Location = new System.Drawing.Point(117, 46);
            this.txtharf.Name = "txtharf";
            this.txtharf.Size = new System.Drawing.Size(100, 20);
            this.txtharf.TabIndex = 11;
            // 
            // txtgecmedurumu
            // 
            this.txtgecmedurumu.Enabled = false;
            this.txtgecmedurumu.Location = new System.Drawing.Point(117, 79);
            this.txtgecmedurumu.Name = "txtgecmedurumu";
            this.txtgecmedurumu.Size = new System.Drawing.Size(100, 20);
            this.txtgecmedurumu.TabIndex = 11;
            // 
            // groupBoxsonuc
            // 
            this.groupBoxsonuc.Controls.Add(this.lblort);
            this.groupBoxsonuc.Controls.Add(this.txtgecmedurumu);
            this.groupBoxsonuc.Controls.Add(this.lblharfnotu);
            this.groupBoxsonuc.Controls.Add(this.txtharf);
            this.groupBoxsonuc.Controls.Add(this.lblgecmedurumu);
            this.groupBoxsonuc.Controls.Add(this.txtort);
            this.groupBoxsonuc.Location = new System.Drawing.Point(324, 19);
            this.groupBoxsonuc.Name = "groupBoxsonuc";
            this.groupBoxsonuc.Size = new System.Drawing.Size(262, 120);
            this.groupBoxsonuc.TabIndex = 12;
            this.groupBoxsonuc.TabStop = false;
            this.groupBoxsonuc.Text = "Sonuçlar";
            this.groupBoxsonuc.Visible = false;
            // 
            // Vize_Final_Ortalama_Hesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 223);
            this.Controls.Add(this.groupBoxsonuc);
            this.Controls.Add(this.combogecmenotu);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.combofinaloran);
            this.Controls.Add(this.combovizeoran);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblbutunleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbüt);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtvize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Vize_Final_Ortalama_Hesaplama";
            this.Text = "Vize Final Ortalama Hesaplama";
            this.groupBoxsonuc.ResumeLayout(false);
            this.groupBoxsonuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtbüt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbutunleme;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.ComboBox combovizeoran;
        private System.Windows.Forms.ComboBox combofinaloran;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.ComboBox combogecmenotu;
        private System.Windows.Forms.Label lblort;
        private System.Windows.Forms.Label lblharfnotu;
        private System.Windows.Forms.Label lblgecmedurumu;
        private System.Windows.Forms.TextBox txtort;
        private System.Windows.Forms.TextBox txtharf;
        private System.Windows.Forms.TextBox txtgecmedurumu;
        private System.Windows.Forms.GroupBox groupBoxsonuc;
    }
}