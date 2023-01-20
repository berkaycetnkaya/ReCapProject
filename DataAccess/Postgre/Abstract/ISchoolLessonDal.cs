using Core.DataAccess;
using Entities.DTOs;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Abstract
{
    public interface ISchoolLessonDal : IEntityRepository<SchoolLesson>
    {
        List<SchoolLessonDto> GetSchoolDetails(Expression<Func<SchoolLessonDto, bool>> filter);
    }
}
