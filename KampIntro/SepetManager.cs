using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)  //signature
        {
            Console.WriteLine("Sepete Eklendi : " + product.Name);
        }

        public void Add2(string productName, string comment, double prize)
        {
            Console.WriteLine("Sepete Eklendi : " + productName);
        }
    }
}
