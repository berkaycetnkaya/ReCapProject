using Core.DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        public List<Car> GetById(int İd);

        public List<Car> GetAll(Car car);

        public void Add(Car car);

        public void Update(Car car);

        public void Delete(Car car);
       
    }
}
