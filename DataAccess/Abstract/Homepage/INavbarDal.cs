﻿using Core.DataAccess;
using Entities;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.Homepage
{
    public interface INavbarDal : IEntityRepository<Navbar>
    {
    }
}