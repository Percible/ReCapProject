using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class SuccessResult : Result
    {
        public SuccessResult(string messages) : base(messages, true)
        {
        }

        public SuccessResult() : base(true)
        {

        }
    }
}
