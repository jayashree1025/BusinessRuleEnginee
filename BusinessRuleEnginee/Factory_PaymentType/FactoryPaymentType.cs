
using BusinessRuleEnginee.PaymentRules;

namespace BusinessRuleEnginee.Factory_PaymentType
{
   public class FactoryPaymentType
    {
    public static IPayment GetPaymentObject(int objType)

        {
            IPayment _IPayment;

            if (objType == Common.OrderTypes.OrderType.PhysicalProduct.GetHashCode())
            {
                _IPayment = new Payment_PhysicalProduct();
            }
            else if (objType == Common.OrderTypes.OrderType.Book.GetHashCode())
            {
                _IPayment = new Payment_Books();
            }
            else if (objType == Common.OrderTypes.OrderType.MembershipActivate.GetHashCode())
            {
                _IPayment = new Payment_ActiveMembership();
            }
            else if (objType == Common.OrderTypes.OrderType.MembershipUpgrade.GetHashCode())
            {
                _IPayment = new Payment_UpgradeMembership();
            }
            else if (objType == Common.OrderTypes.OrderType.Video.GetHashCode())
            {
                _IPayment = new Payment_Video();
            }
            else
            {
                _IPayment = null;
            }
            return _IPayment;
        }

    }
}
