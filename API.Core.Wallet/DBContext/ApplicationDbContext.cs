﻿using API.Core.Wallet.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Wallet.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<MoneyCurrencys>? MoneyCurrencies { get; set; }
        public DbSet<Users>? Users { get; set; }
        public DbSet<Wallets>? Wallets { get; set; } // Prueba de cambio
        public DbSet<Balances>? Balances { get; set; }  
    }
}
