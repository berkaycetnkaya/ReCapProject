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
            using (TablesContext context = new TablesContext())
            {
                var resultt = from p in context.Cars
                              join c in context.Brands
                              on p.BrandId equals c.Id
                              join k in context.Colors
                              on p.ColorId equals k.Id
                              select new CarDetailDto
                              {
                                  Id = p.Id,
                                  BrandId = p.BrandId,
                                  BrandName = c.Name,
                                  ColorId = p.ColorId,
                                  ColorName = k.Name,
                                  ModelYear = p.ModelYear,
                                  DailyPrice = p.DailyPrice,
                                  Description = p.Description,

                              };

                return filter == null ? resultt.ToList() : resultt.Where(filter).ToList();




            }
        }
    }
}

