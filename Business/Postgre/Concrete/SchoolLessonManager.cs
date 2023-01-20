using Business.Postgre.Abstract;
using Business.Postgre.ConstantMessage.Lesson;
using Business.Postgre.ConstantMessage.School;
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
    public class SchoolLessonManager : ISchoolLessonService
    {

        ISchoolLessonDal _lessonDal;
        public SchoolLessonManager(ISchoolLessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public IResult Add(SchoolLesson school)
        {
           _lessonDal.Add(school);
           return new SuccessResult(SchoolMessages.SchoolAdded);
        }

        public IResult Delete(SchoolLesson school)
        {
            _lessonDal.Delete(school);  
            return new SuccessResult(SchoolMessages.SchoolDeleted);
        }

        public IDataResult<List<SchoolLesson>> GetByID(int id)
        {
            return new SuccessDataResult<List<SchoolLesson>>(_lessonDal.GetAll(p=>p.schoolId==id),LessonMessages.LessonListedById);
        }

        public IResult Update(SchoolLesson school)
        {
           _lessonDal.Update(school);   
            return new SuccessResult(SchoolMessages.SchoolUpdated); 
        }
    }
}
