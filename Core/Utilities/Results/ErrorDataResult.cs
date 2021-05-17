using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        ///medsaj olayına girmek istemeyebilir..
        ///
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //sadece mesaj vermek isteyebilir
        public ErrorDataResult(string message) : base(default, false, message)
        {
            ////çalıştıgımm T nin default hali yani oldugu gibi kalsın istiyorum. 
        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
