using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
           // araba ismi mınımum 2 karekter olacak
           //arabada dailyprice 0 dan büyük olacak
            
            
            
            _carDal.Add(car);   
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);   
            
        }

        public List<CarDetailDto> GetAllDto()
        {
            return _carDal.GetCarDetails();  
        }

        public Car GetById(int id)
        {
            //return _carDal.Get(p => p.Id == id);
           
            return _carDal.Get((p => p.Id == id));
        
                
        }

        public void Update(Car car)
        {
            _carDal.Update(car);    
        }
    }
}
