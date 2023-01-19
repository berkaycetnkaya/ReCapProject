using Core.Utilities.Results;
using Entities;
using Entities.PostgreSql.EntitiesPostgre;
using Entities.PostgreSql.PostgreDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Abstract
{
    public  interface ISchoolService
    {
        public IDataResult<List<SchoolDto>> GetByID(int id);
        public IDataResult<List<SchoolDto>> GetAllDto();
        IResult Add(School school);

        IResult Update(School school);

        IResult Delete(School school);
    }
}
