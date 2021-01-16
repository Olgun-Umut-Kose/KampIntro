using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun)
        {

            Console.WriteLine($"Sepete eklendi : { urun.Adi }");

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine($"Sepete eklendi : { urunAdi }");
        }

    }
}
