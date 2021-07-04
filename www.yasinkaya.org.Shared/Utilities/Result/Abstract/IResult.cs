using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Concrete;
using www.yasinkaya.org.Shared.Utilities.Result.ComplexTypes;

namespace www.yasinkaya.org.Shared.Utilities.Result.Abstract
{
    public interface IResult
    {
        //sadece get bırakıyorum, daha sonradan değiştiremileyecek
        public ResultStatus ResultStatus { get; } //ResultStatus.Success // ResultStatus.Error
        public string Message { get; }
        public Exception Exception { get; }
        public IEnumerable<ValidationError> ValidationErrors { get; set; }
    }

   
}
