using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message):this(success)
        {
            Message = message;
            ///nasıl set ettik? constructor dışında set etmeyeceğiz.set koyarsak programcı olayı kafasına göre kodlar.tip dönüşümlerinin constructor ile yapacağız.kafasına göre kullasnmsın diye
            //successi set etmeyi aşağıdaki arkadaşa verdik.:this(success) yazarak tek parametreli constructorı da beraber çalıştır demek dont repeat yourself için yaptık.
        }

        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
