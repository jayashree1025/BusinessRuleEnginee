using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEnginee.Common
{
    class OrderTypes
    {
        public enum OrderType
        {
            PhysicalProduct = 1,
            Book = 2,
            MembershipActivate = 3,
            MembershipUpgrade = 4,
            Video = 5
        }

    }
}
