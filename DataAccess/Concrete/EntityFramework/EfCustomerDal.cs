using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Tables;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,TablesContext>,ICustomerDal
    {

        public List<CustomerDetailDto> GetCustomerDetail()
        {
            using (TablesContext context = new TablesContext())
            {
                var resultt = from p in context.Users
                             join c in context.Customers
                             on p.Id equals c.Id

                             select new CustomerDetailDto
                             {
                                 Id = p.Id,
                                 FirstName = p.FirstName,
                                 LastName = p.LastName,
                                 CompanyName = c.CompanyName,
                                 

                             };

                return resultt.ToList();




            }
        }


    }
}
