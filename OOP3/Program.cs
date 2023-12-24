using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKredisiManager = new TasitKredisiManager();
            IKrediManager konutKredisiManager =new KonutKredisiManager();


            BasvuruManager  basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKredisiManager);

            List<IKrediManager> krediler=new List<IKrediManager>() { ihtiyacKrediManager,tasitKredisiManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
            Console.ReadLine();
        }
    }
}
