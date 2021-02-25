using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class Result : IResult
    {
        public Result(bool success,string messages):this(success)
        {
            Masseges = messages;
        }
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }


        public string Masseges { get; }
    }
}
