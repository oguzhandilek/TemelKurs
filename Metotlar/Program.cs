using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.ProductPrice = 15;
            product1.ProductDescription = "Amasya";
            product1.StockQuantity = 20;

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Karpuz";
            product2.ProductPrice = 80;
            product2.ProductDescription = "Diyarbakır";
            product2.StockQuantity = 20;

            Product[] products= new Product[] { product1, product2 };

            foreach(Product product in products)
            {
                Console.WriteLine(product.Id+" "+" "+product.ProductName +" "+product.ProductPrice+" "+product.ProductDescription);

            }
            Console.WriteLine("----------Metotlar------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            Console.ReadLine();

        }
    }
}
