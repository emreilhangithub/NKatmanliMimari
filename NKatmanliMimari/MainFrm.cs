using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer; 
using DataAccessLayer;
using LogicLayer; //oluşturdugumuz katmanları refens olarak ekledik ve burda cagırdık

namespace UIlayer
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
                //entity personel git bu liste içersinde perList adında bir değer oluştur
                //oluşturulan değişkene değer ata LLPersonelListesi ata
                dataGridView1.DataSource = PerList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }          
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                EntityPersonel ent = new EntityPersonel(); //nesne türekttik
                ent.Ad = txtAd.Text;
                ent.Soyad = txtSoyad.Text;
                ent.Sehir = txtSehir.Text;
                ent.Maas = short.Parse(txtMaas.Text);
                ent.Gorev = txtGorev.Text;
                LogicPersonel.LLPersonelEkle(ent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = short.Parse(txtId.Text);
                LogicPersonel.LLPersonelSil(ent.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                EntityPersonel ent = new EntityPersonel(); //nesne türekttik
                ent.Id = short.Parse(txtId.Text);
                ent.Ad = txtAd.Text;
                ent.Soyad = txtSoyad.Text;
                ent.Sehir = txtSehir.Text;
                ent.Maas = short.Parse(txtMaas.Text);
                ent.Gorev = txtGorev.Text;
                LogicPersonel.LLPersonelGuncelle(ent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txtGorev.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                txtMaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }            
        }
    }
}
