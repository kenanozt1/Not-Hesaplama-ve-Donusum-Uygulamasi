
namespace Üniversite_Not_Hesaplama
{
    partial class Form1
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
            this.btnVizeFinalOrt = new System.Windows.Forms.Button();
            this.btnVizeİleFinalBulma = new System.Windows.Forms.Button();
            this.btnSeneSonuOrt = new System.Windows.Forms.Button();
            this.btnsayiçevirme = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVizeFinalOrt
            // 
            this.btnVizeFinalOrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVizeFinalOrt.Location = new System.Drawing.Point(3, 3);
            this.btnVizeFinalOrt.Name = "btnVizeFinalOrt";
            this.btnVizeFinalOrt.Size = new System.Drawing.Size(218, 147);
            this.btnVizeFinalOrt.TabIndex = 0;
            this.btnVizeFinalOrt.Text = "Vize Final Ortalama";
            this.btnVizeFinalOrt.UseVisualStyleBackColor = true;
            this.btnVizeFinalOrt.Click += new System.EventHandler(this.btnVizeFinalOrt_Click);
            // 
            // btnVizeİleFinalBulma
            // 
            this.btnVizeİleFinalBulma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVizeİleFinalBulma.Location = new System.Drawing.Point(3, 156);
            this.btnVizeİleFinalBulma.Name = "btnVizeİleFinalBulma";
            this.btnVizeİleFinalBulma.Size = new System.Drawing.Size(218, 148);
            this.btnVizeİleFinalBulma.TabIndex = 1;
            this.btnVizeİleFinalBulma.Text = "Vize ile Final Notu Bulma";
            this.btnVizeİleFinalBulma.UseVisualStyleBackColor = true;
            this.btnVizeİleFinalBulma.Click += new System.EventHandler(this.btnVizeİleFinalBulma_Click);
            // 
            // btnSeneSonuOrt
            // 
            this.btnSeneSonuOrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeneSonuOrt.Location = new System.Drawing.Point(227, 156);
            this.btnSeneSonuOrt.Name = "btnSeneSonuOrt";
            this.btnSeneSonuOrt.Size = new System.Drawing.Size(219, 148);
            this.btnSeneSonuOrt.TabIndex = 2;
            this.btnSeneSonuOrt.Text = "Sene Sonu Genel Ortalama";
            this.btnSeneSonuOrt.UseVisualStyleBackColor = true;
            this.btnSeneSonuOrt.Click += new System.EventHandler(this.btnSeneSonuOrt_Click);
            // 
            // btnsayiçevirme
            // 
            this.btnsayiçevirme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnsayiçevirme.Location = new System.Drawing.Point(227, 3);
            this.btnsayiçevirme.Name = "btnsayiçevirme";
            this.btnsayiçevirme.Size = new System.Drawing.Size(219, 147);
            this.btnsayiçevirme.TabIndex = 3;
            this.btnsayiçevirme.Text = "Onluk | İkilik Çevirme";
            this.btnsayiçevirme.UseVisualStyleBackColor = true;
            this.btnsayiçevirme.Click += new System.EventHandler(this.btnsayiçevirme_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnVizeFinalOrt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSeneSonuOrt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnsayiçevirme, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVizeİleFinalBulma, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 307);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 307);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Üniversite Not Hesaplama";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVizeFinalOrt;
        private System.Windows.Forms.Button btnVizeİleFinalBulma;
        private System.Windows.Forms.Button btnSeneSonuOrt;
        private System.Windows.Forms.Button btnsayiçevirme;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

