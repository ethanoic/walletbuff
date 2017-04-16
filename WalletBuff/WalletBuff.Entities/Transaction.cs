using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace WalletBuff.Entities
{
    public class Transaction
    {
        public long ID { get; set; }
        public decimal Amount { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public DateTime DateTime { get; set; }

        public TransactionType? TransactionType { get; set; }

        public virtual BankAccount BankAccount { get; set; }
    }

    public enum TransactionType
    {
        Withdrawal = -1,
        Deposit = 1
    }
}