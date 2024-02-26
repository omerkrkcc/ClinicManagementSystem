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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            formMuayeneler muayeneler = new formMuayeneler();
            this.Hide();
            muayeneler.ShowDialog();
            this.Show();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            formHastaEkleme hastaEkleme = new formHastaEkleme();
            this.Hide();
            hastaEkleme.ShowDialog();
            this.Show();
        }

        private void btnDKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
