using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient; //sql kütüphanesi ekledik
using System.Data; // ConnectionState kullanmak için ekledik

namespace DataAccessLayer
{
    public class DALPersonel
    {
        //Listeleme işlemi için bir method tanımlayacagız
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("select * from Tbl_Personel", Baglanti.bgl);
            //eninty personellerden değerler adında bir nesne türettik
            if (komut1.Connection.State != ConnectionState.Open) //bağlantı acık degilse
            {
                komut1.Connection.Open(); //baglantiyi ac
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = short.Parse(dr["Perid"].ToString());
                ent.Ad = dr["PerAd"].ToString();
                ent.Soyad = dr["PerSoyad"].ToString();
                ent.Gorev = dr["PerMeslek"].ToString();
                ent.Sehir = dr["PerSehir"].ToString();
                ent.Maas = short.Parse(dr["PerMaas"].ToString());
                degerler.Add(ent); //değerlerin içersine ekle ent den gelen değerleri
            }

            dr.Close();
            return degerler; 

        }
    }
}
