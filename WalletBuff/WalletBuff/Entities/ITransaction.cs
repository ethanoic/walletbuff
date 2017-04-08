using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalletBuff.Entities
{
    public abstract class ITransaction
    {
        TransactionType TransactionType;
        decimal Amount;
        decimal Balance;
        string Description;
    }
}
