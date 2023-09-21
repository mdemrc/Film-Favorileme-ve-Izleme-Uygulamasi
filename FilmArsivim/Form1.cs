using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=GRANGER\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        public void filmlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblFilmler", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizlefilmekle()
        {
            txtFilm.Clear();
            txtKategori.Clear();
            txtLink.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmlistesi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TblFilmler (AD,KATEGORI,LINK) VALUES (@p1,@p2,@p3)", bgl);
            komut.Parameters.AddWithValue("@p1", txtFilm.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            filmlistesi();
            temizlefilmekle();
            MessageBox.Show("Film listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Mehmet Demirci tarafından 8.09.2023 tarihinde kodlanmıştır.", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnRenkDegistir_Click(object sender, EventArgs e)
        {
            string[] renkler = new string[] { "Blue", "red", "yellow", "cadetblue", "purple", "green", "pink", "aqua", "white", "hottrack" };
            Random rnd = new Random();
            int sayi=rnd.Next(0, renkler.Length);
            this.BackColor = Color.FromName(renkler[sayi]);

        }

        private void BtnTamEkran_Click(object sender, EventArgs e)
        {
            FrmTamEkran fr = new FrmTamEkran();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.link2 = link;
            fr.Show();
        }
    }
}
