using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult
    {
        // data ve sonuc aynı anda gosterılıyor
        // T her sey olabilir 
        // aşağıdakı sekilde olur bir interface e baska bir interface implement edılırse

        // bool Success { get; }   

        //string Message { get; }
        T Data { get; }
    }
}
