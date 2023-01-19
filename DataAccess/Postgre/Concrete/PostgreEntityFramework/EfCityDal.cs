using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Tables;
using DataAccess.Postgre.Abstract;
using Entities;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Concrete.PostgreEntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, PostgreDbContext>, ICityDal
    {
    }
}
