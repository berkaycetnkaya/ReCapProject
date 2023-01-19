using Business.Postgre.Abstract;
using Business.Postgre.ConstantMessage.Lesson;
using Core.Utilities.Results;
using DataAccess.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Concrete
{
    public class LessonManager : ILessonService

       

    {

        ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }
    
        public IResult Add(Lesson lesson)
        {
            _lessonDal.Add(lesson);
         return   new SuccessResult(LessonMessages.LessonAdded);
        }

        public IResult Delete(Lesson lesson)
        {
            _lessonDal.Delete(lesson);  
            return new SuccessResult(LessonMessages.LessonDeleted);
        }

        public IDataResult<List<Lesson>> GetAll()
        {
            return new SuccessDataResult<List<Lesson>>(_lessonDal.GetAll(),LessonMessages.LessonListed);   
        }

        public IDataResult<Lesson> GetByID(int id)
        {
            return new SuccessDataResult<Lesson>(_lessonDal.Get(p=>p.id==id),LessonMessages.LessonListed);
        }

        public IResult Update(Lesson lesson)
        {
            _lessonDal.Update(lesson);
            return new SuccessResult(LessonMessages.LessonUpdated);

        }
    }
}
