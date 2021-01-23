using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        //Method Injection
        public void Applying(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Basvuran bilgilerini degerlendirme
            //
            
            creditManager.Calculate();
            loggerService.Log();   
            //PULL REQUEST Ex..
        }

        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
