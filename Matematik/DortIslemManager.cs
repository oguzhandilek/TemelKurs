using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class DortIslemManager
    {
     public void Topla(Entity entity)
        {
            double Sonuc=entity.Sayi1+entity.Sayi2;
            Console.WriteLine("Sayıların Toplamı: "+Sonuc.ToString());
        }
        public void Cikarma(Entity entity)
        {
            double Sonuc=entity.Sayi1-entity.Sayi2;
            Console.WriteLine("Sayıların Sonucu: " + Sonuc.ToString());
        }

        public void Çarpma(Entity entity) {

            double Sonuc = entity.Sayi1 * entity.Sayi2;
            Console.WriteLine("Sayıların Çarpımı: "+  Sonuc.ToString());
        }

        public void Bolme(Entity entity)
        {
            double sonuc= entity.Sayi1 / entity.Sayi2;
            Console.WriteLine("Sayıların Bölümü: " + sonuc.ToString());
        }
    }
}
