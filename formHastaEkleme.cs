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
    public partial class formHastaEkleme : Form
    {
        public formHastaEkleme()
        {
            InitializeComponent();
        }
        NpgsqlConnection sqlErisim = new NpgsqlConnection("Server=localHost;Port=5432;Database=mbysUygulamasi;User Id=postgres;Password=admin");
        public void formuHazırla()
        {
            txtHastaNo.Text = "";
            txtHastaAdi.Text = "";
            txtKimlikNo.Text = "";
            txtHastaSoyadi.Text = "";
            txtDogumYeri.Text = "";
            txtDogumTarihi.Text = "";
            txtAdresBilgisi.Text = "";
            txtMedeniHal.Text = "";
            txtTelefonNo.Text = "";  
            txtHastaNo.Focus();
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
                dataGridEkle.DataSource = dataTable;
            }
            komut.Dispose();
            sqlErisim.Close();
        }


        private void formHastaEkleme_Load(object sender, EventArgs e)
        {

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlErisim.Open();
            NpgsqlCommand komutEkle = new NpgsqlCommand();
            komutEkle.Connection = sqlErisim;

            komutEkle.Parameters.AddWithValue("@hasta_numarasi", Convert.ToDouble(txtHastaNo.Text));
            komutEkle.Parameters.AddWithValue("@hasta_adi", txtHastaAdi.Text);
            komutEkle.Parameters.AddWithValue("@hasta_soyadi", txtHastaSoyadi.Text);
            komutEkle.Parameters.AddWithValue("@hasta_dogum_tarihi",txtDogumTarihi.Text);
            komutEkle.Parameters.AddWithValue("@hasta_dogum_yeri", txtDogumYeri.Text);
            komutEkle.Parameters.AddWithValue("@hasta_kimlik_no", Convert.ToDouble(txtKimlikNo.Text));
            komutEkle.Parameters.AddWithValue("@hasta_telefonu", Convert.ToDouble(txtTelefonNo.Text));
            komutEkle.Parameters.AddWithValue("@hasta_adresi", txtAdresBilgisi.Text);
            komutEkle.Parameters.AddWithValue("@hasta_medeni_hal", txtMedeniHal.Text);

            komutEkle.CommandType = CommandType.Text;
            komutEkle.CommandText = "insert into hastabilgileri (hasta_numarasi,hasta_adi,hasta_soyadi,hasta_dogum_tarihi,hasta_dogum_yeri,hasta_kimlik_no,hasta_telefonu,hasta_adresi,hasta_medeni_hal) values (@hasta_numarasi,@hasta_adi,@hasta_soyadi,@hasta_dogum_tarihi,@hasta_dogum_yeri,@hasta_kimlik_no,@hasta_telefonu,@hasta_adresi,@hasta_medeni_hal)";

            NpgsqlDataReader dataReader = komutEkle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridEkle.DataSource = dataTable;
            }
            komutEkle.Dispose();
            sqlErisim.Close();
            verileriListele("select * from hastabilgileri");
            formuHazırla();

        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            verileriListele("select * from hastabilgileri");
        }

        private void btnRandevuEkranı_Click(object sender, EventArgs e)
        {
            formMuayeneTalebi talep = new formMuayeneTalebi();
            this.Hide();
            talep.ShowDialog();
            this.Show();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
