using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserCoreDal : EfEntityRepositoryBase<UserCore, TablesContext>, IUserCoreDal
    {
         
        
            public List<OperationClaim> GetClaims(UserCore user)
            {
                using (var context = new TablesContext())
                {
                    var result = from operationClaim in context.OperationClaims
                                 join userOperationClaim in context.UserOperationClaims
                                     on operationClaim.Id equals userOperationClaim.OperationClaimId
                                 where userOperationClaim.UserId == user.Id
                                 select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                    return result.ToList();

                }
            }
        }
    }

