using Core.DataAccess;
using Entities;
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
    public interface ISchoolDal : IEntityRepository<School>
    {

        List<SchoolDto> GetByIdSchoolDto(Expression<Func<SchoolDto, bool>> filter);

        List<SchoolDto> GetAllSchoolDto(Expression<Func<SchoolDto, bool>> filter = null);
    }
}
