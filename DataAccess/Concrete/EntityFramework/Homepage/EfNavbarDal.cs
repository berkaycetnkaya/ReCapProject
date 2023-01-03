﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Abstract.Homepage;
using DataAccess.Concrete.Tables;
using Entities;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Homepage
{
    public class EfNavbarDal: EfEntityRepositoryBase<Navbar, TablesContext>, INavbarDal
    {
    }
}
