using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WalletBuffApp.DataContext
{
    public class WalletBuffInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WalletContext>
    {
        protected override void Seed(WalletContext context)
        {

        }

    }
}