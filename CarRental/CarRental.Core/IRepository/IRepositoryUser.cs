﻿using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Core.IRepository
{
    public interface IRepository<T>
    {
         List<T> GetAllData();
        T GetById(int id);
         bool Add(T user);

        bool Update(T user);
        bool Delete(int id);
    }
}
