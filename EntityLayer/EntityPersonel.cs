using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class EntityPersonel
        //public yaparsak diger sınıflardanda ulaşılabilir olur bu katmana
    {
        private short id; //smallint
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;

        public short Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }
        
    }
}
