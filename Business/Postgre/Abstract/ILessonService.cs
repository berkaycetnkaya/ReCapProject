using Core.Utilities.Results;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Abstract
{
    public interface ILessonService
    {

        public IDataResult<Lesson> GetByID(int id);
        public IDataResult<List<Lesson>> GetAll();
        IResult Add(Lesson lesson);

        IResult Update(Lesson lesson);

        IResult Delete(Lesson lesson);
    }
}
