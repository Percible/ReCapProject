using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,string messages,bool isSuccess) : base(messages,isSuccess)
        {
            this.Data = data;
        }

        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            this.Data= data;
        }

        public T Data { get; }
    }
}
