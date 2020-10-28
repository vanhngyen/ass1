using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ass1.Models
{
    public class DealAndAccountContext:DbContext
    {
        public DealAndAccountContext() : base("name=Asignment1Context")
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deal> Deals { get; set; }
    }
}