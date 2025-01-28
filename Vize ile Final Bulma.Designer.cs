
namespace Üniversite_Not_Hesaplama
{
    partial class Vize_ile_Final_Bulma
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtvize = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.combovizeoran = new System.Windows.Forms.ComboBox();
            this.combogecmenotu = new System.Windows.Forms.ComboBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vize Notu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vize Oranı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Geçme Notu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Final :";
            // 
            // btnhesapla
            // 
            this.btnhesapla.BackColor = System.Drawing.Color.Lime;
            this.btnhesapla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(12, 157);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(205, 34);
            this.btnhesapla.TabIndex = 3;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = false;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(85, 15);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(121, 20);
            this.txtvize.TabIndex = 0;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(82, 123);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 13);
            this.lblsonuc.TabIndex = 0;
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
            this.combovizeoran.Location = new System.Drawing.Point(85, 45);
            this.combovizeoran.Name = "combovizeoran";
            this.combovizeoran.Size = new System.Drawing.Size(121, 21);
            this.combovizeoran.TabIndex = 1;
            this.combovizeoran.Text = "0,4";
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
            this.combogecmenotu.Location = new System.Drawing.Point(85, 76);
            this.combogecmenotu.Name = "combogecmenotu";
            this.combogecmenotu.Size = new System.Drawing.Size(121, 21);
            this.combogecmenotu.TabIndex = 2;
            this.combogecmenotu.Text = "50";
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.Red;
            this.btntemizle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(12, 197);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(205, 34);
            this.btntemizle.TabIndex = 3;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Vize_ile_Final_Bulma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 241);
            this.Controls.Add(this.combogecmenotu);
            this.Controls.Add(this.combovizeoran);
            this.Controls.Add(this.txtvize);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Vize_ile_Final_Bulma";
            this.Text = "Vİze İle Final Notu Bulma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.ComboBox combovizeoran;
        private System.Windows.Forms.ComboBox combogecmenotu;
        private System.Windows.Forms.Button btntemizle;
    }
}