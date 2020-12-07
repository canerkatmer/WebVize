using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace caner.Models
{
    public class ogrenci
    {
        public int id { get; set; }
        public string isim { get; set;  }
        public string soyisim { get; set; }
        public string adres { get; set; }
        public string OgrenciNo { get; set; }


        public static List<ogrenci> ogrencis = new List<ogrenci>
        {
            {
                new ogrenci{
                    id = 1,
                isim = "a",
                soyisim="a",
                adres ="a",
                OgrenciNo="12",
                }
                 
            },
            {
                  new ogrenci{
                    id = 2,
                isim = "b",
                soyisim="b",
                adres ="b",
                OgrenciNo="13",
                }
            },
        };
    }
}