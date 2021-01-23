using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerNo = "12345";
            customer1.Name = "Guney";
            customer1.Surname = "Sanli";
            customer1.Id = 1;
            customer1.IdNo = "123";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.CustomerNo = "21342";
            customer2.CompanyName = "Coder.io";
            customer2.Id = 2;
            customer2.TaxNo = "1323";

            //Gerçek müsteri - tüzel müsteri
            //SOLID - L

            Customer customer3 = new RealCustomer();         //new refence 
            Customer customer4 = new LegalCustomer();


            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);



        }
    }
}
