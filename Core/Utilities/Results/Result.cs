using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(string messages, bool isSuccess) : this(isSuccess)
        {
            Messages = messages;

        }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }




        public string Messages { get; }

        public bool IsSuccess { get; }
    }
}
