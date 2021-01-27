using System;
using System.Collections.Generic;
using System.Text;


// Micro service

namespace GameProject
{
    class GamerManager : IGamerService
    {

        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if(userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Başarıssız");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayıt güncellendi");
        }
    }
}
