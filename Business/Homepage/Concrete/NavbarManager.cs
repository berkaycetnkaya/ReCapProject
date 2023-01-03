using Business.Constants;
using Business.Constants.Homepage;
using Business.Constants.Messages;
using Business.Homepage.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract.Homepage;
using Entities;
using Entities.DTOs;
using Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Homepage.Concrete
{
    public class NavbarManager : INavbarService
    {
        INavbarDal _navbardal;
        public NavbarManager(INavbarDal navbardal)
        {
            _navbardal=navbardal;   


        }
        public IResult Add(Navbar nav)
        {
            _navbardal.Add(nav);
            return new SuccessResult(NavbarMessages.NavAdded);
        }

        public IResult Delete(Navbar nav)
        {
            _navbardal.Delete(nav);
            return new SuccessResult(NavbarMessages.NavDeleted);
        }

        public IDataResult<List<Navbar>> GetAll()
        {
            return new SuccessDataResult<List<Navbar>>(_navbardal.GetAll(), NavbarMessages.NavListed);
        }

        public IResult Update(Navbar nav)
        {
            _navbardal.Update(nav);
            return new SuccessResult(NavbarMessages.NavUpdated);
        }
    }
}
