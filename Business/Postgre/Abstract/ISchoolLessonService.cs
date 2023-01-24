using Core.Utilities.Results;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Abstract
{
    public interface ISchoolLessonService
    {
        public IDataResult<List<SchoolLessonDto>> GetByID(int id);
        public IDataResult<List<SchoolLessonDto>> GetAllDto();

        IResult Add(SchoolLesson school);

        IResult Update(SchoolLesson school);

        IResult Delete(SchoolLesson school);
    }
}
