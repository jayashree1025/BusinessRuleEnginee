﻿using System;
using BusinessRuleEnginee.PaymentRules;

namespace BusinessRuleEnginee
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultValue;
            Console.WriteLine("Please choose any Order type:");
            Console.WriteLine("1: Phyiscal Product\n" +

            "2: Book\n" +
            "3: Memebership\n" +
            "4: Upgrade to a Memebership\n" +

            "5: Video\n");

            Console.WriteLine("********************************");
            var getUserInput = Console.ReadLine();

            if (Int32.TryParse(getUserInput, out resultValue))
            {
                ProcessPaymentOrder(resultValue);
            }
            else
            {
                Console.WriteLine("Please enter a valid option Number!");
            }
            Console.Read();

        }
        private static void ProcessPaymentOrder(int PaymentType)
        {
            IPayment paymentProcessing = Factory_PaymentType.FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing == null)
            {
                Console.WriteLine("Invalid option!");
            }
            else
            {
                paymentProcessing.ProcessPayment();
            }
        }
    }
}
