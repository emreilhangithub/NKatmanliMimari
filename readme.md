# NKatmanliMimari

## Proje Tanıtımı 

*Bu projede, **.Net**  platformu kullanılarak üç katmanlı mimariye sahip bir personel yönetim uygulaması geliştirdim. Uygulamada CRUD operasyonları için ADO.NET kullandım. Mimari olarak **N-katmanlı** bir yapı tercih ettim.*

# Database Yedeği #
Databse kısmına aşşağıdan ulaşıp kendinize yükleyebilirsiniz. https://github.com/emreilhangithub/NKatmanliMimari/tree/master/database

# Proje İçeriği #

### Anasayfa

**1)Kullanıcı Arayüzü (UI Layer):**

UI katmanı, Windows Forms uygulaması olan "MainFrm" formunu içerir.

Bu form, kullanıcı arayüzü bileşenlerini (DataGridView, TextBox, vb.) barındırır.

Kullanıcı arayüzünde "Listele", "Ekle", "Sil" ve "Güncelle" gibi butonlar bulunur ve bunlara tıklanması durumunda ilgili işlevler çalıştırılır.


![MainForm](https://github.com/emreilhangithub/NKatmanliMimari/blob/master/images/MainForm.png)

**2)Mantık Katmanı (Logic Layer):**

LogicLayer içinde, iş mantığını barındıran "LogicPersonel" sınıfı bulunur.

Bu sınıf, UI katmanından gelen istekleri alır, gerektiğinde veritabanı işlemlerini çağırır ve sonuçları UI katmanına döndürür.

"LLPersonelListesi", "LLPersonelEkle", "LLPersonelSil" ve "LLPersonelGuncelle" gibi metotlar, personel verileriyle ilgili işlemleri gerçekleştirir.


![LogicLayer](https://github.com/emreilhangithub/NKatmanliMimari/blob/master/images/LogicLayer.png)


**3)Veri Erişim Katmanı (Data Access Layer):**

DataAccessLayer içinde, veritabanı işlemlerinin yapıldığı "DALPersonel" sınıfı bulunur.

Bu sınıf, veritabanı bağlantısı kurar ve gerekli SQL sorgularını çalıştırarak veritabanı işlemlerini gerçekleştirir.

"PersonelListesi", "PersonelEkle", "PersonelSil" ve "PersonelGuncelle" gibi metotlar, veritabanı işlemlerini gerçekleştirir.


![DataAccessLayer](https://github.com/emreilhangithub/NKatmanliMimari/blob/master/images/DataAccessLayer.png)


**4)Varlık Katmanı (Entity Layer):**

EntityLayer içinde, veritabanındaki personel tablosunu temsil eden "EntityPersonel" sınıfı bulunur.

Bu sınıf, personel verilerini tutan özelliklere (Id, Ad, Soyad, vb.) sahiptir.


![EntityLayer](https://github.com/emreilhangithub/NKatmanliMimari/blob/master/images/EntityLayer.png)


**5)Bağlantı Sınıfı:**
Bağlanti sınıfı, veritabanı bağlantısını yönetir. Bu sınıf, veritabanına bağlanmak için gerekli bilgileri sağlar.


![Baglanti](https://github.com/emreilhangithub/NKatmanliMimari/blob/master/images/Baglanti.png)


Proje, UI, Mantık ve Veri Erişim katmanları arasında iyi bir ayrım sağlar. Bu, uygulamanın bakımı, genişletilmesi ve test edilmesi açısından faydalıdır. UI katmanı kullanıcı arayüzü ile ilgilenirken, Mantık katmanı iş mantığını uygular ve Veri Erişim katmanı ise veritabanı ile iletişim kurar. Bu ayrım, kodun daha organize ve yönetilebilir olmasını sağlar.

```.NET``` ```C#``` ```WindowsForm``` ```Software``` ```Computer``` ```Programmer``` 
