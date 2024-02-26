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
    public partial class formMuayeneTalebi : Form
    {
        public formMuayeneTalebi()
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
                dataGridView1.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;

            komutEkle.Parameters.AddWithValue("@kimliknumarasi", Convert.ToDouble(txtKimlikNo.Text));
            komutEkle.Parameters.AddWithValue("@sikayet",richTextSikayet.Text);
            komutEkle.Parameters.AddWithValue("@tarih", dateTimeMuayene.Value);

            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "INSERT INTO muayenebilgileri  (kimliknumarasi,sikayet, tarih) VALUES (@kimliknumarasi,@sikayet,@tarih)";

            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            verileriListele("select hasta_adi,hasta_soyadi,muayenebilgileri.kimliknumarasi,hasta_dogum_tarihi,sikayet,tarih from hastabilgileri,muayenebilgileri where hastabilgileri.hasta_kimlik_no=muayenebilgileri.kimliknumarasi");
        }

        private void btnRandevuGoruntule_Click(object sender, EventArgs e)
        {
            verileriListele("select hasta_adi,hasta_soyadi,muayenebilgileri.kimliknumarasi,hasta_dogum_tarihi,sikayet,tarih from hastabilgileri,muayenebilgileri where hastabilgileri.hasta_kimlik_no=muayenebilgileri.kimliknumarasi");
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
