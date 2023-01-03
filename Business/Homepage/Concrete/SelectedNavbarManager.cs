using Business.Constants;
using Business.Constants.Homepage;
using Business.Homepage.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.Homepage;
using DataAccess.Concrete.EntityFramework.Homepage;
using Entities;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Homepage.Concrete
{
    public class SelectedNavbarManager:ISelectedService
    {
        ISelectedNavbarDal _selecteddal;

        public SelectedNavbarManager(ISelectedNavbarDal selecteddal)
        {
            _selecteddal = selecteddal; 
        }

        public IResult Add(SelectedNavbar nav)
        {
            _selecteddal.Add(nav);
            return new SuccessResult(NavbarMessages.NavAdded);
        }

        public IResult Delete(SelectedNavbar nav)
        {
            _selecteddal.Delete(nav);
            return new SuccessResult(NavbarMessages.NavDeleted);
        }

        public IDataResult<List<SelectedNavbar>> GetAll()
        {
            return new SuccessDataResult<List<SelectedNavbar>>(_selecteddal.GetAll(), NavbarMessages.NavListed);
        }

        public IDataResult<SelectedNavbar> GetById(int id)
        {
            return new SuccessDataResult<SelectedNavbar>(_selecteddal.Get(p => p.Id == id), NavbarMessages.NavListed);
        }

        public IResult Update(SelectedNavbar nav)
        {
            _selecteddal.Update(nav);
            return new SuccessResult(NavbarMessages.NavUpdated);
        }
    }
}
