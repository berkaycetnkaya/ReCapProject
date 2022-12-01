using Core.Entities;
using Entities;
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
        Color _color;
        public GenericMessages(Color color)
        {
            _color = color;
        }

        public string Added(T entity)
        {
            entity.
            throw new NotImplementedException();
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
