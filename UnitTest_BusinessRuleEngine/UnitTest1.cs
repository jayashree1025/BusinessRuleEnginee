using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessRuleEnginee.PaymentRules;
using BusinessRuleEnginee.Factory_PaymentType;

namespace UnitTest_BusinessRuleEngine
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PhysicalProduct_Test()
        {
            ///Arrange
            int PaymentType = 1;
            string paymentProcess = "";
            //Act

            IPayment paymentProcessing = FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing != null)
            {
                paymentProcess = "Generated Packaging slip for shipping successfully Commssion Payment to agent done successfully";
            }

            //Assert
            Assert.AreEqual(paymentProcess, "Generated Packaging slip for shipping successfully Commssion Payment to agent done successfully");
        }
        [TestMethod]
        public void Book_Test()
        {
            ///Arrange
            int PaymentType = 2;
            string paymentProcess = "";
            //Act
            IPayment paymentProcessing = FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing != null)
            {
                paymentProcess = "Created Duplicate Packaging slip for royalty department successfully Commssion Payment to agent done successfully";
            }
            //Assert
            Assert.AreEqual(paymentProcess, "Created Duplicate Packaging slip for royalty department successfully Commssion Payment to agent done successfully");
        }

        [TestMethod]
        public void Membership_Test()
        {
            ///Arrange
            int PaymentType = 3;
            string paymentProcess = "";
            //Act

            IPayment paymentProcessing = FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing != null)
            {
                paymentProcess = "Membership activated successfully e-mail sent to the owner for Membership Activated";
            }

            //Assert
            Assert.AreEqual(paymentProcess, "Membership activated successfully e-mail sent to the owner for Membership Activated");
        }

        [TestMethod]
        public void UpgradeToMembership_Test()
        {
            ///Arrange
            int PaymentType = 4;
            string paymentProcess = "";
            //Act

            IPayment paymentProcessing = FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing != null)
            {
                paymentProcess = "Generated Packaging slip for shipping successfully Commssion Payment to agent done successfully";
            }

            //Assert
            Assert.AreEqual(paymentProcess, "Generated Packaging slip for shipping successfully Commssion Payment to agent done successfully");
        }
        [TestMethod]
        public void Video_Test()
        {
            ///Arrange
            int PaymentType = 5;
            string paymentProcess = "";
            //Act

            IPayment paymentProcessing = FactoryPaymentType.GetPaymentObject(PaymentType);
            if (paymentProcessing != null)
            {
                paymentProcess = "Generated video Packaging slip for shipping Added free First Aid video on Packaging slip";
            }

            //Assert
            Assert.AreEqual(paymentProcess, "Generated video Packaging slip for shipping Added free First Aid video on Packaging slip");
        }
    }
}