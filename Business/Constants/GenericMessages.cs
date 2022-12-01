using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class GenericMessages<T> : IGenericMessages<T>
        where T : class, IEntity, new() 
    {
        public string Added(T entity)
        {
            string message = entity + "eklendi";
            return message;
            
        }

        public string Deleted(T entity)
        {
            throw new NotImplementedException();
        }

        public string Listed(T entity)
        {
            throw new NotImplementedException();
        }

        public string Updated(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
