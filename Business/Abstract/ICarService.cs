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

        public Car GetById(int id);


        public List<CarDetailDto> GetAllDto();

        public void Add(Car car);

        public void Update(Car car);

        public void Delete(Car car);
       

    }
}
