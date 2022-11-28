using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccess
{
    public class InMemory 
    {
        List<Car> _cars;
        public InMemory()
        {
            _cars = new List<Car> { new Car { Id = "1", BrandId = "1", ColorId = "1", DailyPrice = 200, Description = "BMW ", ModelYear = 2022 },
            new Car    { Id = "2", BrandId = "2", ColorId = "2", DailyPrice = 400, Description = "Mercedes ", ModelYear = 2022 } };
        }

        public void Add(Car car)
        {
            _cars.Add(car); 
        }

        public void Delete(Car car)
        {
           
          Car  carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Car car)
        {
            return _cars;
        }

        public List<Car>  GetById(int İd)
        {
            return _cars;
        }

        public void Update(Car car)
        {
            // gönderdiğim ürün id'sine sahip olanı bul demek
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;  
        }
    }









}

