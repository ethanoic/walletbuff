using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WalletBuffApp.Models;

namespace WalletBuffApp.DataContext
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("WalletContext", throwIfV1Schema: false)
        {
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}