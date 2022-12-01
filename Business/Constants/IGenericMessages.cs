using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public interface IGenericMessages<T> where T : class,IEntity,new()  
    {
        string Added(T entity);
        string Deleted(T entity);

        string Updated(T entity );
        string Listed(T entity);

    }
}
