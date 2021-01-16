using System;

namespace ValueAndRefencesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;

        }
    }
}
