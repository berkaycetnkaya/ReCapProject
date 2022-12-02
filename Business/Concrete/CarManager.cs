using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
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

    // aşagiya kullanacağin nesnenin servisini cagirip işlem yaparsin
        IBrandService _brandService;    
        public CarManager(ICarDal carDal, IBrandService brandService)
        {
            _carDal = carDal;
            _brandService = brandService;   
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //bussiness code
            //validation

            // aşağıya valıdation rulesları koyabılırsın
            IResult result = BusinessRules.Run();
            if(result != null)
            {
                return result;
            }

            


            _carDal.Add(car);   
            return new SuccessResult(CarMessages.CarAdded); 
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult( CarMessages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new  SuccessDataResult<List<Car>>(_carDal.GetAll(),CarMessages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetAllDto()
        {
            
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetAllCarDetails(),CarMessages.CarDetailListed);
        }

        public IDataResult<List<CarDetailDto>> GetByColorId(int colorid)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(p => p.ColorId == colorid), CarMessages.CarListedByColorId);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id),CarMessages.CarListedById);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);    
            return new SuccessResult(CarMessages.CarUpdated);
        }
    }
}
