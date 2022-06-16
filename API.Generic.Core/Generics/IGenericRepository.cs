﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Generic.Core.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int? id);
    }
}
