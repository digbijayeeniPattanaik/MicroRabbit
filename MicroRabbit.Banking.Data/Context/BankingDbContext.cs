using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MicroRabbit.Banking.Data
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Account> Accounts { get; set; }
    }
}
