using DataAccess.Abstract;
using DataAccess.Concrete.Tables;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal

    {
        public void Add(Car car)
            //us tab tab yap, 
        {
            // Idisposable pattern implementation of c#
            using (TablesContext context = new TablesContext())
            {
                var addedEntity = context.Entry(car);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(Car car)
        {
            using (TablesContext context = new TablesContext())
            {
                var deletedEntity = context.Entry(car);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int İd)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
