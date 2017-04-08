using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletBuff.Entities
{
    public abstract class IAccount
    {
        string Currency;
        string BankCode;
        string BranchCode;
        AccountType AccountType;
    }
}
