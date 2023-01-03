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
    public interface ISelectedService
    {

        public IDataResult<List<SelectedNavbar>> GetAll();
        IDataResult<SelectedNavbar> GetById(int id);
        IResult Add(SelectedNavbar nav);

        IResult Update(SelectedNavbar nav);

        IResult Delete(SelectedNavbar nav);
    }
}
