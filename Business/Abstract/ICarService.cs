using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        public List<Car> GetById(Car car);


        public List<Car> GetAll(Car car);

        public void Add(Car car);

        public void Update(Car car);

        public void Delete(Car car);
       

    }
}
