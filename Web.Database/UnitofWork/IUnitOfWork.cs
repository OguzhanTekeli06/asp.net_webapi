﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Database.Repository;

namespace Web.Database.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICityRepository Cities {  get; }

        Task<int> CompleteAsync();
    }
}
