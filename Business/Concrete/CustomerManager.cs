using Business.Abstract;
using Business.Constants.Messages;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
           _customerDal = customerDal;  
        }
    
        public IResult Add(Customer customer)
        {
           _customerDal.Add(customer);
            return new SuccessResult(CustomerMessages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(CustomerMessages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),CustomerMessages.CustomerListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.Id == id),CustomerMessages.CustomerListedById);
        }

        public IDataResult<List<CustomerDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetail());
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(CustomerMessages.CustomerUpdated);
        }
    }
}
