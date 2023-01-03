using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
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
    public class EfSelectedNavbarDal : EfEntityRepositoryBase<SelectedNavbar, TablesContext>, ISelectedNavbarDal
    {
    }
}
