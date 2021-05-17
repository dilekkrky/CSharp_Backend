using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{ 
    //Temel voidler için başlangıc ,data yok
   public interface IResult
    {//get sadece okunabilir dememk set yazılabilr demek
        bool Success { get; }
        string Message { get; }
    }
}
