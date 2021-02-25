using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,bool success,string messages):base(data,true,messages)
        {

        }
        public SuccessDataResult(T data,bool success):base(data,true)
        {

        }
        public SuccessDataResult():base(default,true)
        {

        }
        public SuccessDataResult(string messages):base(default,true,messages)
        {

        }
    }
}
