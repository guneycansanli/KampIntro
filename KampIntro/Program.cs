using Metotlar;
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();

            product1.Name = "Apple";
            product1.prize = 80;
            product1.comment = "Best Apple";

            Product product2 = new Product();

            product2.Name = "Water Melon";
            product2.prize = 15;
            product2.comment = "Reddish WaterMelon";

            Product[] products = new Product[] {product1, product2 };

            //type safe  -- tip güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.comment);
                Console.WriteLine(product.prize);
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("------------------Metodlar------------");

            //instance
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Banana", "Yellow Banana", 12);



           
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practise
