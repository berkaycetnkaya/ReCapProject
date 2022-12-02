using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Tables;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, TablesContext>, ICarDal

    {
        public List<CarDetailDto> GetAllCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (TablesContext context = new TablesContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             join k in context.Colors
                             on p.ColorId equals k.Id
                             select new CarDetailDto
                             {
                                 Id = p.BrandId,
                                 BrandName = c.Name,
                                 ColorId = k.Id,
                                 ColorName = k.Name,
                                 ModelYear = p.ModelYear,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,

                             };

                return result.ToList();




            }
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter)
        {
            using (TablesContext context = new TablesContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.BrandId equals c.Id
                             join k in context.Colors
                             on p.ColorId equals k.Id
                             select new CarDetailDto
                             {
                                 Id = p.BrandId,
                                 BrandName = c.Name,
                                 ColorId = k.Id,
                                 ColorName = k.Name,
                                 ModelYear = p.ModelYear,
                                 DailyPrice = p.DailyPrice,
                                 Description = p.Description,

                             };

                return result.ToList();
                             

                             

            }
        }
    }
}
        

      

       
    
