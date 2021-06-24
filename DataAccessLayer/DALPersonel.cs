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

        public static int PersonelEkle(EntityPersonel p) //p sınıflara ulasmamızı saglar
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek) VALUES(@PerAd,@PerSoyad,@PerSehir,@PerMaas,@PerMeslek) ", Baglanti.bgl);
            komut2.Parameters.AddWithValue("@PerAd",p.Ad);
            komut2.Parameters.AddWithValue("@PerSoyad", p.Soyad);
            komut2.Parameters.AddWithValue("@PerSehir", p.Sehir);
            komut2.Parameters.AddWithValue("@PerMaas", p.Maas);
            komut2.Parameters.AddWithValue("@PerMeslek", p.Gorev);

            if (komut2.Connection.State != ConnectionState.Open) 
            {
                komut2.Connection.Open();
            }
            return komut2.ExecuteNonQuery(); //kayıt sayısını döndürdük
        }

        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("DELETE FROM Tbl_Personel where Perid=@Perid",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@Perid",p);
            return komut3.ExecuteNonQuery() > 0; //şartları saglayan değer varsa true gönder yani 1 
        }

    }
}
