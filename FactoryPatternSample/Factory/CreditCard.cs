using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternSample
{
    public interface CreditCard
    {
        CardType GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
