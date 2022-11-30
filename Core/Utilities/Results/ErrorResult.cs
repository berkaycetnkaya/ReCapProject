using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        // hata aldıgında mesaj gosterme

        public ErrorResult(string message) : base(false, message)

        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
}
