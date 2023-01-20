using Core.DataAccess.EntityFramework;
using DataAccess.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Concrete.PostgreEntityFramework
{
    public class EfSchoolLessonDal : EfEntityRepositoryBase<SchoolLesson, PostgreDbContext>, ISchoolLessonDal
    {
    }
}

