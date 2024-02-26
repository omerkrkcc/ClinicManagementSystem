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
    public partial class formMuayeneler : Form
    {
        public formMuayeneler()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=mbysUygulamasi;User Id=postgres;Password=admin");
        public void formuHazırla()
        {
            txtHastaBulgu.Text = "";
            txtHastaTedavi.Text = "";
            txtHastaTeshis.Text = "";
            txtKimlikNo.Text = "";
        }
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
                dataGridView2.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {

            string kimlikNumarasi = txtKimlikNo.Text;

            sqlErisim.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = sqlErisim;

            komut_ekle.Parameters.AddWithValue("@kimlik_no", Convert.ToDecimal(txtKimlikNo.Text));
            komut_ekle.Parameters.AddWithValue("@bulgu", txtHastaBulgu.Text);
            komut_ekle.Parameters.AddWithValue("@teshis", txtHastaTeshis.Text);
            komut_ekle.Parameters.AddWithValue("@tedavi", txtHastaTedavi.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into muayenedetaylari(kimliknumarasi,bulgu,teshis, tedavi) values (@kimlik_no,@bulgu, @teshis, @tedavi)";


            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView2.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            sqlErisim.Close();
            verileriListele2("SELECT tarih,concat(hasta_adi,'   ',hasta_soyadi) as ad_soyad,concat(hasta_dogum_tarihi,hasta_dogum_yeri) as dogumyeri_tarihi,bulgu,teshis,tedavi from muayenebilgileri,muayenedetaylari,hastabilgileri where muayenebilgileri.kimliknumarasi=muayenedetaylari.kimliknumarasi and hastabilgileri.hasta_kimlik_no=muayenebilgileri.kimliknumarasi and muayenebilgileri.kimliknumarasi='" + kimlikNumarasi + "' ");
            formuHazırla();

        }

        private void btnRecete_Click(object sender, EventArgs e)
        {
            verileriListele("delete from ilacisimleri1");

            formReceteSistemi receteSistemi = new formReceteSistemi();
            receteSistemi.txtKimlikNo.Text = txtKimlikNo.Text;     
            this.Hide();
            receteSistemi.ShowDialog();
            this.Show();
        }

        private void btnMevcutRandevular_Click(object sender, EventArgs e)
        {
            string kimlikNumarasi = txtKimlikNo.Text;

            verileriListele("select hasta_adi,hasta_soyadi,muayenebilgileri.kimliknumarasi,hasta_dogum_tarihi,tarih,sikayet from hastabilgileri,muayenebilgileri   where hastabilgileri.hasta_kimlik_no=muayenebilgileri.kimliknumarasi ");
        }

        private void btnTedaviEdilmis_Click(object sender, EventArgs e)
        {
            verileriListele2("SELECT tarih,concat(hasta_adi,'   ',hasta_soyadi) as ad_soyad,concat(hasta_dogum_tarihi,' / ',hasta_dogum_yeri) as dogumyeri_tarihi,bulgu,teshis,tedavi from muayenebilgileri,muayenedetaylari,hastabilgileri where muayenebilgileri.kimliknumarasi=muayenedetaylari.kimliknumarasi and hastabilgileri.hasta_kimlik_no=muayenebilgileri.kimliknumarasi ");
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
