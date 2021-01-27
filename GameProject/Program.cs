using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer
            {
                id = 1,
                BirthYear = 1984,
                FirstName = "Enigin",
                LastName = "Demir",
                IdentityNumber = 1234
            });

            Console.WriteLine("Hello World!");
        }
    }
}
