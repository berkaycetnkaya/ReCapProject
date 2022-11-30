﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
          
            return  _brandDal.GetAll();
        }

        public Brand GetByBrandId(int id)
        {
            return _brandDal.Get(p => p.Id == id);
           
        }


    }
}
