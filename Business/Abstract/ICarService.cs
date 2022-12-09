using Core.Utilities.Results;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAll();
         IDataResult<Car> GetById(int id);
        IDataResult <List<CarDetailDto>> GetByColorId(int colorid);

        IDataResult <List<CarDetailDto>> GetAllDto();

         IResult Add(Car car);

         IResult Update(Car car);

         IResult Delete(Car car);
        IDataResult<List<Car>> GetByBrandId(int brand);
    }
}
