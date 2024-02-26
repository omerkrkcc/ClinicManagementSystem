
namespace MuayeneSistemiUygulamasi
{
    partial class formMuayeneTalebi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMuayeneTalebi));
            this.lblDersAkts = new System.Windows.Forms.Label();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeMuayene = new System.Windows.Forms.DateTimePicker();
            this.richTextSikayet = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.btnRandevuGoruntule = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDKapat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDersAkts
            // 
            this.lblDersAkts.AutoSize = true;
            this.lblDersAkts.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDersAkts.Location = new System.Drawing.Point(390, 57);
            this.lblDersAkts.Name = "lblDersAkts";
            this.lblDersAkts.Size = new System.Drawing.Size(192, 23);
            this.lblDersAkts.TabIndex = 42;
            this.lblDersAkts.Text = "Hasta Kimlik Numarası";
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(653, 59);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.Size = new System.Drawing.Size(166, 22);
            this.txtKimlikNo.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Muayene Tarihi";
            // 
            // dateTimeMuayene
            // 
            this.dateTimeMuayene.Location = new System.Drawing.Point(653, 123);
            this.dateTimeMuayene.Name = "dateTimeMuayene";
            this.dateTimeMuayene.Size = new System.Drawing.Size(200, 22);
            this.dateTimeMuayene.TabIndex = 44;
            // 
            // richTextSikayet
            // 
            this.richTextSikayet.Location = new System.Drawing.Point(357, 205);
            this.richTextSikayet.Name = "richTextSikayet";
            this.richTextSikayet.Size = new System.Drawing.Size(566, 96);
            this.richTextSikayet.TabIndex = 45;
            this.richTextSikayet.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(609, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Şikayet";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.Color.Teal;
            this.btnRandevuOlustur.ForeColor = System.Drawing.Color.White;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(357, 355);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(234, 37);
            this.btnRandevuOlustur.TabIndex = 50;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // btnRandevuGoruntule
            // 
            this.btnRandevuGoruntule.BackColor = System.Drawing.Color.Teal;
            this.btnRandevuGoruntule.ForeColor = System.Drawing.Color.White;
            this.btnRandevuGoruntule.Location = new System.Drawing.Point(689, 355);
            this.btnRandevuGoruntule.Name = "btnRandevuGoruntule";
            this.btnRandevuGoruntule.Size = new System.Drawing.Size(234, 37);
            this.btnRandevuGoruntule.TabIndex = 50;
            this.btnRandevuGoruntule.Text = "Randevuları Görüntüle";
            this.btnRandevuGoruntule.UseVisualStyleBackColor = false;
            this.btnRandevuGoruntule.Click += new System.EventHandler(this.btnRandevuGoruntule_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(110, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1133, 218);
            this.dataGridView1.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 44);
            this.panel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(619, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Randevu Olusturma";
            // 
            // btnDKapat
            // 
            this.btnDKapat.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDKapat.BackgroundImage")));
            this.btnDKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDKapat.FlatAppearance.BorderSize = 0;
            this.btnDKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKapat.ForeColor = System.Drawing.Color.White;
            this.btnDKapat.Location = new System.Drawing.Point(1223, 0);
            this.btnDKapat.Name = "btnDKapat";
            this.btnDKapat.Size = new System.Drawing.Size(46, 44);
            this.btnDKapat.TabIndex = 0;
            this.btnDKapat.UseVisualStyleBackColor = false;
            this.btnDKapat.Click += new System.EventHandler(this.btnDKapat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 606);
            this.panel2.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CadetBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 261);
            this.label7.TabIndex = 0;
            this.label7.Text = "H\r\nA\r\nS\r\nT\r\nA\r\nH\r\nA\r\nN\r\nE";
            // 
            // formMuayeneTalebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRandevuGoruntule);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.richTextSikayet);
            this.Controls.Add(this.dateTimeMuayene);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDersAkts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMuayeneTalebi";
            this.Text = "formMuayeneTalebi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDersAkts;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeMuayene;
        private System.Windows.Forms.RichTextBox richTextSikayet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.Button btnRandevuGoruntule;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDKapat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}