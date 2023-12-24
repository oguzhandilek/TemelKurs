using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Entity entity1 = new Entity();
            entity1.Sayi1=12;
            entity1.Sayi2=6;   


            DortIslemManager dortIslemManager = new DortIslemManager();
            dortIslemManager.Topla(entity1);
            dortIslemManager.Cikarma(entity1);
            dortIslemManager.Çarpma(entity1);
            dortIslemManager.Bolme(entity1);
            

           
            Console.ReadLine();
        }
    }
}
