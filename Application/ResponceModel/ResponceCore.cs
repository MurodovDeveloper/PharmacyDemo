using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ResponceModel
{
    public class ResponseCore<T>
    {
        public ResponseCore(T Result)
        {
            this.Result = Result;
        }
        public ResponseCore(bool IsSuccess, object Errors)
        {
            this.IsSuccess = IsSuccess;
            this.Errors = Errors;
        }
        public ResponseCore()
        {

        }
        public bool IsSuccess { get; set; } = true;

        public T Result { get; set; }

        public object Errors { get; set; }
    }
}
