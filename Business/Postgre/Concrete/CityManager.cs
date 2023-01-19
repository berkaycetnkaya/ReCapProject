using Business.Postgre.Abstract;
using Business.Postgre.ConstantMessage.City;
using Core.Utilities.Results;
using DataAccess.Postgre.Abstract;
using Entities.PostgreSql.EntitiesPostgre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Postgre.Concrete
{
    public class CityManager : ICityService

    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
    
        public IResult Add(City city)
        {
            _cityDal.Add(city);
           return new  SuccessResult(CityMessages.CityAdded);    
        }

        public IResult Delete(City city)
        {
           _cityDal.Delete(city);   
            return new SuccessResult(CityMessages.CityDeleted); 
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll()); 
        }

        public IDataResult<City> GetByID(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(p=>p.id== id),CityMessages.CityListedById); 
        }

        public IResult Update(City city)
        {
            _cityDal.Update(city);  
            return new SuccessResult(CityMessages.CityUpdated);
        }
    }
}
