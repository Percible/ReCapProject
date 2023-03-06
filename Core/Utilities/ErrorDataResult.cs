using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string messages) : base(data, messages, false)
        {


        }


        public ErrorDataResult(T data) : base(data, false)
        {


        }

        public ErrorDataResult(string messages) : base(default, messages, false)
        {


        }

        public ErrorDataResult() : base(default, false)
        {


        }
    }
}
