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
    public class EfSchoolDal : EfEntityRepositoryBase<School, PostgreDbContext>, ISchoolDal
    {

        public List<SchoolDto> GetAllSchoolDto(Expression<Func<SchoolDto, bool>> filter = null)
        {
            using (PostgreDbContext context = new PostgreDbContext())
            {
                var result = from p in context.Schools
                             join c in context.Cities
                             on p.cityId equals c.id
                            
                             select new SchoolDto
                             {
                                 Id = p.id,
                                 Name = p.name,
                                 BuildDate = p.buildDate,
                                 StartDate = p.startDate,
                                 
                                 EndDate = p.endDate,
                                 CityId = p.id,
                                
                                 CityName = c.name
                             };

                return result.ToList();



            }
        }

        public List<SchoolDto> GetByIdSchoolDto(Expression<Func<SchoolDto, bool>> filter)
        {
            using (PostgreDbContext context = new PostgreDbContext())
            {
                var resultt = from p in context.Schools
                              join c in context.Cities
                              on p.cityId equals c.id
                              
                              select new SchoolDto
                              {
                                  Id = p.id,
                                  Name = p.name,
                                  BuildDate = p.buildDate,
                                  StartDate = p.startDate,

                                  EndDate = p.endDate,
                                  CityId = p.id,
                                 
                                  CityName = c.name

                              };

                return filter == null ? resultt.ToList() : resultt.Where(filter).ToList();




            }
        }
    }
}
