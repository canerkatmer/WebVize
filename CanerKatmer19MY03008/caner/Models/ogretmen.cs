using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace caner.Models
{
    public class ogretmen
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string adres { get; set; }
        public string Dersadi{ get; set; }

        public static List<ogretmen> ogretmenx = new List<ogretmen>
        {
            {
                new ogretmen{
                isim = "A",
                soyisim="A",
                adres ="A",
                id = 1,
                Dersadi="A",
                }

            },
             new ogretmen{
                isim = "B",
                soyisim="B",
                adres ="B",
                id = 1,
                Dersadi="B",
                }
        };
    }
}