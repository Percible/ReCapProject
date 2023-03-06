using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public interface IResult
    {

        string Messages { get; }
        bool IsSuccess { get; }

    }
}
