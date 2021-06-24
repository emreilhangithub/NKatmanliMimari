using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //bu kütüphaneyi eklemeyi unutma

namespace DataAccessLayer
{
   public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection
            (@"Data Source=DESKTOP-E9UTSVL;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
    }
}
