using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEnginee.PaymentRules
{
   public class Payment_Video : IPayment
    {
        public bool ProcessPayment()
        {
            return GeneratePackagingSlip_Video();
        }

        public bool GeneratePackagingSlip_Video()
        {
            Console.WriteLine("Generated video Packaging slip for shipping");
            return this.AddFreeVideo();
        }

        private bool AddFreeVideo()
        {
            Console.WriteLine("free 'First Aid' video Added");
            return true;
        }

    }
}
