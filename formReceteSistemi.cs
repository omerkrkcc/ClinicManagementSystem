using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MuayeneSistemiUygulamasi
{
    public partial class formReceteSistemi : Form
    {
        public formReceteSistemi()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=mbysUygulamasi;User Id=postgres;Password=admin");
        public void verileriListele(string txt)
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridRecete.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        public void verileriListele2(string txt)
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = sqlErisim;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            sqlErisim.Open();
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridHastalar.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnHastaGoruntule_Click(object sender, EventArgs e)
        {
            string kimlikNumarasi = txtKimlikNo.Text;
            verileriListele2("select hasta_adi,hasta_dogum_tarihi,bulgu,teshis,tedavi from hastabilgileri,muayenedetaylari where hastabilgileri.hasta_kimlik_no=muayenedetaylari.kimliknumarasi and muayenedetaylari.kimliknumarasi='" + kimlikNumarasi + "'");
        }
        private void txtKimlikNo_TextChanged(object sender, EventArgs e)
        {

        }
        public static int kontrol = 0;
        private void btnReceteYazdir_Click(object sender, EventArgs e)
        {
            string kimlikNumarasi = txtKimlikNo.Text;
            string ilac1 = textBox1.Text;
            string ilac2 = textBox3.Text;
            string ilac3 = textBox4.Text;
            string ilac4 = textBox7.Text;

            verileriListele("select hastabilgileri.hasta_adi, hastabilgileri.hasta_kimlik_no,muayenebilgileri.tarih,muayenedetaylari.teshis, ilacisimleri1.ilacismi, ilacisimleri1.ilacsayisi, ilacisimleri2.kategori, ilacisimleri2.barkodnumarasi from ilacisimleri1, ilacisimleri2, hastabilgileri, muayenebilgileri, muayenedetaylari where ilacisimleri1.ilacismi = ilacisimleri2.ilacismi and hastabilgileri.hasta_kimlik_no = muayenebilgileri.kimliknumarasi and muayenebilgileri.kimliknumarasi = muayenedetaylari.kimliknumarasi  and   (ilacisimleri1.ilacismi= '" + ilac1 + "'   or ilacisimleri1.ilacismi='" + ilac2 + "'  or  ilacisimleri1.ilacismi='" + ilac3 + "'   or ilacisimleri1.ilacismi='" + ilac4 + "')    and hastabilgileri.hasta_kimlik_no = '" + kimlikNumarasi + "'");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;


            string kimlikNumarasi = txtKimlikNo.Text;



            komutEkle.Parameters.AddWithValue("@ilacadi", textBox1.Text);
            komutEkle.Parameters.AddWithValue("@ilacsayisi", Convert.ToInt32(textBox2.Text));


            kontrol = Convert.ToInt32(textBox2.Text);

            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into ilacisimleri1  (ilacismi, ilacsayisi ) values (@ilacadi, @ilacsayisi)";
            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridRecete.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();


            MessageBox.Show(textBox2.Text + "kadar" + textBox1.Text + "  isimli ilaç eklendi. "+ "  " + "Kalan hakkınız:" + (5 - kontrol).ToString());

            verileriListele("select  ilacisimleri1.ilacismi,ilacsayisi,kategori,barkodnumarasi from ilacisimleri1, ilacisimleri2 where ilacisimleri1.ilacismi = ilacisimleri2.ilacismi");
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;


            string kimlikNumarasi = txtKimlikNo.Text;

            komutEkle.Parameters.AddWithValue("@ilacadi", textBox3.Text);
            komutEkle.Parameters.AddWithValue("@ilacsayisi", Convert.ToInt32(textBox5.Text));

            kontrol += Convert.ToInt32(textBox5.Text);
            if (kontrol >= 5)
            { 

   
                label3.Enabled = false;
                textBox4.Enabled = false;
                textBox6.Enabled = false;
                btnEkle3.Enabled = false;

                label4.Enabled = false;
                textBox7.Enabled = false;
                textBox9.Enabled = false;
                btnEkle4.Enabled = false;

               
                label5.Enabled = false;
                textBox8.Enabled = false;
                textBox10.Enabled = false;
                btnEkle5.Enabled = false;
            }
            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into ilacisimleri1  (ilacismi, ilacsayisi ) VALUES (@ilacadi, @ilacsayisi)";
            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridRecete.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            MessageBox.Show(textBox5.Text + "kadar" + textBox3.Text + "  isimli ilaç eklendi. " + "  " + "Kalan hakkınız:" + (5 - kontrol).ToString());
            verileriListele("select  ilacisimleri1.ilacismi,ilacsayisi,kategori,barkodnumarasi from ilacisimleri1, ilacisimleri2 where ilacisimleri1.ilacismi = ilacisimleri2.ilacismi");
        }

        private void btnEkle3_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;

            string kimlikNumarasi = txtKimlikNo.Text;
            komutEkle.Parameters.AddWithValue("@ilacadi", textBox4.Text);
            komutEkle.Parameters.AddWithValue("@ilacsayisi", Convert.ToInt32(textBox6.Text));

            kontrol += Convert.ToInt32(textBox5.Text);
            if (kontrol >= 5)
            { 

                label4.Enabled = false;
                textBox7.Enabled = false;
                textBox9.Enabled = false;
                btnEkle4.Enabled = false;


                label5.Enabled = false;
                textBox8.Enabled = false;
                textBox10.Enabled = false;
                btnEkle5.Enabled = false;
            }
            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into ilacisimleri1  (ilacismi, ilacsayisi ) VALUES (@ilacadi, @ilacsayisi)";
            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridRecete.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            MessageBox.Show(textBox6.Text + "kadar" + textBox4.Text + "  isimli ilaç eklendi. " + "  " + "Kalan hakkınız:" + (5 - kontrol).ToString());
            verileriListele("select  ilacisimleri1.ilacismi,ilacsayisi,kategori,barkodnumarasi from ilacisimleri1, ilacisimleri2 where ilacisimleri1.ilacismi = ilacisimleri2.ilacismi");
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formMuayeneler muayeneler = new formMuayeneler();
            this.Hide();
            muayeneler.ShowDialog();
            this.Show();
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle4_Click(object sender, EventArgs e)
        {

        }
    }
}
