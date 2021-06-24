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

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            //entity personel git bu liste içersinde perList adında bir değer oluştur
            //oluşturulan değişkene değer ata LLPersonelListesi ata
            dataGridView1.DataSource = PerList;
        }
    }
}
