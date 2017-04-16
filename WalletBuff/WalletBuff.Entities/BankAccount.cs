using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WalletBuff.Entities
{
    public class BankAccount
    {
        
        public long ID { get; set; }

        [StringLength(6)]
        public string BankCode { get; set; }

        [StringLength(6)]
        public string BranchCode { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(3)]
        public string Currency { get; set; }

        public AccountType? AccountType { get; set; }
        
    }
    public enum AccountType
    {
        Savings = 1,
        Current = 2,
        CreditCard = 3
    }
}