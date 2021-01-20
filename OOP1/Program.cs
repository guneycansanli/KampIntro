using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrize = 500;
            product1.UnitInStock = 3;


            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrize = 35};

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //Case Sensitive
            //int, double, bool... deger tip
            //Diziler , class vs referans tip
        }
    }
}
