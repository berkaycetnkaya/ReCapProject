using Business.Postgre.Abstract;
using Business.Postgre.ConstantMessage.Lesson;
using Business.Postgre.ConstantMessage.School;
using Core.Utilities.Results;
using DataAccess.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Concrete
{
    public class SchoolLessonManager : ISchoolLessonService
    {

        ISchoolLessonDal _schoolLessonDal;
        ILessonService _lesson;

        public SchoolLessonManager(ISchoolLessonDal lessonDal, ILessonService lesson)
        {
            _schoolLessonDal = lessonDal;
            _lesson = lesson;   
        }

        public IResult Add(SchoolLesson school)
        {
            _schoolLessonDal.Add(school);
           return new SuccessResult(SchoolMessages.SchoolAdded);
        }

        public IResult Delete(SchoolLesson school)
        {
            _schoolLessonDal.Delete(school);  
            return new SuccessResult(SchoolMessages.SchoolDeleted);
        }

        public IDataResult<List<SchoolLessonDto>> GetAllDto()
        {
           return new SuccessDataResult<List<SchoolLessonDto>>(_schoolLessonDal.GetAllSchoolDto(),LessonMessages.LessonListed);   
        }

        public IDataResult<List<SchoolLessonDto>> GetByID(int id)
        {
            
            return new SuccessDataResult<List<SchoolLessonDto>>(_schoolLessonDal.GetSchoolDetails(p=>p.schoolId==id),LessonMessages.LessonListedById);
        }

        public IResult Update(SchoolLesson school)
        {
            _schoolLessonDal.Update(school);   
            return new SuccessResult(SchoolMessages.SchoolUpdated); 
        }
    }
}
