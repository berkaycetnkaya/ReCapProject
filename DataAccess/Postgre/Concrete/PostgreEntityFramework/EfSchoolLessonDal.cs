using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.Tables;
using DataAccess.Postgre.Abstract;
using Entities.DTOs;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Postgre.Concrete.PostgreEntityFramework
{
    public class EfSchoolLessonDal : EfEntityRepositoryBase<SchoolLesson, PostgreDbContext>, ISchoolLessonDal
    {
        public List<SchoolLessonDto> GetSchoolDetails(Expression<Func<SchoolLessonDto, bool>> filter)
        {
            using (PostgreDbContext context = new PostgreDbContext())
            {
                var resultt = from p in context.SchoolLessons
                              join c in context.Schools
                              on p.schoolId equals c.id
                              join k in context.Lessons
                              on p.lessonId equals k.id
                              select new SchoolLessonDto
                              {
                                  id =p.id,

         schoolId =c.id,
       schoolName=c.name,
         lessonId=k.id,
                                  BuildDate=c.buildDate,
                                  StartDate=c.startDate,
                                  EndDate=c.endDate,    
       LessonName =k.name,

    };

                return filter == null ? resultt.ToList() : resultt.Where(filter).ToList();




            }
        }

        public List<SchoolLessonDto> GetAllSchoolDto(Expression<Func<SchoolLessonDto, bool>> filter = null)
        {
            using (PostgreDbContext context = new PostgreDbContext())
            {
                var result = from p in context.SchoolLessons
                             join c in context.Schools
                             on p.schoolId equals c.id
                             join k in context.Lessons
                             on p.lessonId equals k.id

                             select new SchoolLessonDto
                             {
                                 id = p.id,

                                 schoolId = c.id,
                                 schoolName = c.name,
                                 lessonId = k.id,
                                 BuildDate = c.buildDate,
                                 StartDate = c.startDate,
                                 EndDate = c.endDate,
                                 LessonName = k.name,
                             };

                return result.ToList();



            }
        }
    }
}

