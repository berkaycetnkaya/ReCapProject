using Core.Utilities.Results;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Homepage.Abstract
{
    public interface ISelectedService
    {

        public IDataResult<List<SelectedNavbar>> GetAll();
        IResult Add(SelectedNavbar nav);

        IResult Update(SelectedNavbar nav);

        IResult Delete(SelectedNavbar nav);
    }
}
