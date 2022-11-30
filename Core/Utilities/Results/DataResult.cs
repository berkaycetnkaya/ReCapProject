using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T>:Result,IDataResult<T>
    {
        public DataResult(T date,bool success,string message):base(success,message)
        {
            Data = date;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
    
        public T Data { get; }
    }
}
