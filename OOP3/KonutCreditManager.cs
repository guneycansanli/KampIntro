using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("konut kredisi odeme planı hesaplandi");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
