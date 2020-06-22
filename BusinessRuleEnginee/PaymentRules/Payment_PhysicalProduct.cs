﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEnginee.PaymentRules
{
    public class Payment_PhysicalProduct : IPayment
    {
        public bool GeneratePackagingSlip_PhysicalProduct()
        {
            Console.WriteLine("Successfully generate a Packing slip for shipping");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Commssion Payment to agent done successfully");
            return true;
        }

        public bool ProcessPayment()
        {
            return GeneratePackagingSlip_PhysicalProduct();
        }

    }
}