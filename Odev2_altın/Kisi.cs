using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_altın
    {
        public class Kisi


        {
            public Kisi(String isim, String cinsiyet)
            {
                Isim = isim;
                Cinsiyet = cinsiyet;
                Altinsayisi = 0;

            }

            public Kisi()

            {
                Isim = "yolcu";
                Cinsiyet = "x";
                Altinsayisi = 0;
            }

            public string Isim { get; set; }
            public string Cinsiyet { get; set; }
            public int Altinsayisi { get; set; }

           


        }
        // 15 adet yolcu(7 bayan, 8 erkek) otobuse rast gele binmistir.
    }

