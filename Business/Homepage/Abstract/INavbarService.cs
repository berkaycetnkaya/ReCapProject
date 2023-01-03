using Core.Utilities.Results;
using Entities;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Homepage.Abstract
{
    public interface INavbarService
    {
        public IDataResult<List<Navbar>> GetAll();
        IResult Add(Navbar nav);

        IResult Update(Navbar nav);

        IResult Delete(Navbar nav);
    }
}
}
