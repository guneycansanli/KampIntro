using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            ApplyManager applyManager = new ApplyManager();

            applyManager.Applying(ihtiyacCreditManager, new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {konutCreditManager, tasitCreditManager };
            //applyManager.CreditPreInfo(credits);
        }
    }
}
