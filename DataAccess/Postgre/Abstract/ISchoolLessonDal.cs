﻿using Core.DataAccess;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Abstract
{
    public interface ISchoolLessonDal : IEntityRepository<SchoolLesson>
    {
    }
}
