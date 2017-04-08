using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalletBuff.Entities;

namespace WalletBuff.Entities.Impl
{
    public class SavingsAccount : IAccount
    {
        public  AccountType AccountType {
            get
            {
                return AccountType.Savings;
            }
        }
        
    }
}
