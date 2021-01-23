using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("ihtiyac kredisi odeme planı hesaplandi");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
