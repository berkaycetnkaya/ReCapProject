using Core.Utilities.Results;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Abstract
{
    public interface ICityService
    {
        public IDataResult<City> GetByID(int id);
        public IDataResult<List<City>> GetAll();
        IResult Add(City city);

        IResult Update(City city);

        IResult Delete(City city);
    }
}
