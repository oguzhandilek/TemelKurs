using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine("Eklenen Ürün: "+ product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Güncellenen Ürün: " + product.ProductName);
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Silinen Ürün: " + product.ProductName);
        }
    }
}
