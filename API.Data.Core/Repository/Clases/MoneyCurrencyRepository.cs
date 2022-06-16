﻿using API.Core.Wallet.DBContext;
using API.Core.Wallet.Entities;
using API.Data.Core.Repository.IRepository;
using API.Generic.Core.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Data.Core.Repository.Clases
{
    public class MoneyCurrencyRepository : GenericRepository<MoneyCurrency>,IMoneyCurrencyRepository
    {
        public MoneyCurrencyRepository(ApplicationDbContext db) : base(db)
        {
        }

       
    }
}