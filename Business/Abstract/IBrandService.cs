using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public IDataResult<Brand> GetByBrandId(int id);
        public  IDataResult <List<Brand>> GetAll();
        IResult Add(Brand brand);

        IResult Update(Brand brand);

        IResult Delete(Brand brand);
    }
}
