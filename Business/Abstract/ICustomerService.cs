﻿using Core.Utilities.Results;
using Entities.DTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int id);


        IDataResult<List<CustomerDetailDto>> GetCustomerDetail();

        IResult Add(Customer customer);

        IResult Update(Customer customer);

        IResult Delete(Customer customer);

    }
}
