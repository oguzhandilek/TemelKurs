using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi: "+product.ProductName+ product.StockQuantity);
        }
    }
}
