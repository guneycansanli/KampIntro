using System;
using System.Collections.Generic;

namespace Colections
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[] {"Engin","Murat", "Kerem", "Halil" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);    //ctrl e ctrl u

            names = new string[5];
            names[4] = "Deneme";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);


            List<string> names2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ilker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            

        }
    }
}
