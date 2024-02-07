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
using System.IO;

namespace EtutTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Etut Test;Integrated Security=True");

        void etutlistesi()
        {
            connection.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("Execute Etut2", connection);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            connection.Close();

        }
        void etutekle()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLETUT (DERSID,TEACHERID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", connection);
            command.Parameters.AddWithValue("@p1", cmbxDers.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbxOgretmen.SelectedValue);
            command.Parameters.AddWithValue("@p3", mskTarih.Text);
            command.Parameters.AddWithValue("@p4", mskSaat.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLDERSLER", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbxDers.ValueMember = "DERSID";
            cmbxDers.DisplayMember = "DERSAD";
            cmbxDers.DataSource = dt;
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            etutlistesi();

        }

        private void cmbxDers_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da2 = new SqlDataAdapter("Select TEACHERID,(AD +' '+SOYAD) as ADSOYAD from TBLOGRETMEN where DERSID=" + cmbxDers.SelectedValue, connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbxOgretmen.ValueMember = "TEACHERID";
            cmbxOgretmen.DisplayMember = "ADSOYAD";
            cmbxOgretmen.DataSource = dt2;


        }

        private void BtnEtut_Click(object sender, EventArgs e)
        {
            etutekle();
            etutlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtEtutId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();

        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update TBLETUT set STUDENTID=@p1,DURUM=@p2 where ID=@p3", connection);
            command.Parameters.AddWithValue("@p1", TxtOgrenci.Text);
            command.Parameters.AddWithValue("@p2", "True");
            command.Parameters.AddWithValue("@p3", TxtEtutId.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt Öğrenciye verildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnFotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            command.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            command.Parameters.AddWithValue("@p4", TxtSinif.Text);
            command.Parameters.AddWithValue("@p5", mskTelefon.Text);
            command.Parameters.AddWithValue("@p6", TxtMail.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci başarı ile eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}