using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
        // temel result klasörü bir boolean ve bir mesaj dondurecek
        public Result(bool success, string message):this(success)
        {
           Message = message;
            
        }

        public bool Success { get; }   
            //=> throw new NotImplementedException();

        public string Message { get; }

        public Result(bool success)
        {
            
            Success = success;
        }



    }
}
