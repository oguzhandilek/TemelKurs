using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
     Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "A";
            kurs1.Egitmen = "B";
            kurs1.IzlenmeOrani = 20;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "CC";
            kurs2.Egitmen = "DD";
            kurs2.IzlenmeOrani = 20;

            //   Console.WriteLine(kurs1.KursAdi + ": " +  kurs1.Egitmen + "  %" , kurs1.IzlenmeOrani);
            Kurs[] kurslar=new Kurs[] { kurs1, kurs2 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.IzlenmeOrani + kurs.Egitmen);
            }
            Console.ReadLine();
        }
        
        public class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
