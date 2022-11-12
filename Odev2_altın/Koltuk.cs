using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_altın
{
    public class Koltuk
    {
        public int No { get; set; }

        public bool Dolu { get; set; }

        public Kisi? Kisi { get; set; }
        public int AltınSayisi { get; internal set; }
    }
}
