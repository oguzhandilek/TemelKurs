using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Oğuzhan","batuhan","Sıdıka","Sütlaç"};
            foreach (string l in list)
            {
                Console.WriteLine(l);
                
            }
            list.Add("Rumeysa");
            Console.WriteLine(list[4]);
            Console.WriteLine(list[0]);
            Console.ReadLine();
        }
    }
}
