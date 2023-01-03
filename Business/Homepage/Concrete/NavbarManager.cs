using Business.Constants;
using Business.Constants.Homepage;
using Business.Constants.Messages;
using Business.Homepage.Abstract;
using Core.Utilities.Results;
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
        INavbarService _navbarservice;
        public NavbarManager(INavbarService navbarservice)
        {
            
            _navbarservice = navbarservice; 
        }
        public IResult Add(Navbar nav)
        {
            _navbarservice.Add(nav);
            return new SuccessResult(NavbarMessages.NavAdded);
        }

        public IResult Delete(Navbar nav)
        {
            _navbarservice.Delete(nav);
            return new SuccessResult(NavbarMessages.NavDeleted);
        }

        public IDataResult<List<Navbar>> GetAll()
        {
            return new SuccessDataResult<List<Navbar>>(_navbarservice.GetAll(), NavbarMessages.NavListed);
        }

        public IResult Update(Navbar nav)
        {
            _navbarservice.Update(nav);
            return new SuccessResult(NavbarMessages.NavUpdated);
        }
    }
}
