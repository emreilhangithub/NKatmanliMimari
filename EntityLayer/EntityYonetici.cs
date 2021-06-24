using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class EntityYonetici
    {
        private int id;
        private string ad;
        private string sifre;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Sifre { get => sifre; set => sifre = value; }
    }
}
