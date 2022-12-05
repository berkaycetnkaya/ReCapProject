using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserCoreManager : IUserCoreService
    {
        IUserCoreDal _userCoreDal;

        public UserCoreManager(IUserCoreDal userCoreDal)
        {
            _userCoreDal = userCoreDal;
        }

        public List<OperationClaim> GetClaims(UserCore user)
        {
            return _userCoreDal.GetClaims(user);
        }

        public void Add(UserCore user)
        {
            _userCoreDal.Add(user);
        }

        public UserCore GetByMail(string email)
        {
            return _userCoreDal.Get(u => u.Email == email);
        }
    }
}
