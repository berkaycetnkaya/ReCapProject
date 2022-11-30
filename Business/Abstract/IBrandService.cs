using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        public Brand GetByBrandId(int id);
        public List<Brand> GetAll();    
    }
}
