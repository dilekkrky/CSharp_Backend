using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        ///medsaj olayına girmek istemeyebilir..
        ///
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //sadece mesaj vermek isteyebilir
        public SuccessDataResult(string message):base(default,true,message)
        {
          ////çalıştıgımm T nin default hali yani oldugu gibi kalsın istiyorum. 
        }
        public SuccessDataResult():base(default,true)
        {

        }
    }
}
