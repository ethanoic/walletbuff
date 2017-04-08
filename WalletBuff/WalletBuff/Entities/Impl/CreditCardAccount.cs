using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletBuff.Entities;

namespace WalletBuff.Entities.Impl
{
    public class CreditCardAccount : IAccount
    {
        public AccountType AccoutType
        {
            get
            {
                return AccountType.CreditCard;
            }
        }
    }
}
