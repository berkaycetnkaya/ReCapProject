﻿using Core.DataAccess;
using Core.Entities.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDetail = Core.Entities.Concrete.UserCore;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {

    }
}
