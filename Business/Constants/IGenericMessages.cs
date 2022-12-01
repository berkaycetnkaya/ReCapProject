using Core.Entities;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface IGenericMessages<T> where T : class,IEntity,new()  
    {
        public string Added(T entity);
        public string Deleted(T entity);

       public string Updated(T entity );
       public string Listed(T entity);

    }
}
