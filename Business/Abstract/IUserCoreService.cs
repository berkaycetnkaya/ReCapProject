using Core.Entities.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserCoreService
    {
        List<OperationClaim> GetClaims(UserCore user);
        void Add(UserCore user);
        UserCore GetByMail(string email);
    }
}
