using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using www.yasinkaya.org.Shared.Entities.Concrete;

namespace www.yasinkaya.org.Mvc.Filters
{
    public class MvcExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _metadataProvider;

        public MvcExceptionFilter(IHostEnvironment environment, IModelMetadataProvider metadataProvider)
        {
            _environment = environment;
            _metadataProvider = metadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            if (_environment.IsDevelopment())
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new MvcErrorModel
                
                {
                    Message = $"Üzgünüz, işleminiz sırasında beklenmedik hata oluştu. En kısa süre içerisinde çözülecektir."

                };
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message = $"Üzgünüz, işleminiz sırasında beklenmedik veritabanı hatası oluştu. En kısa süre içerisinde çözülecektir.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message = $"Üzgünüz, işleminiz sırasında beklenmedik null veriye rastlandı. En kısa süre içerisinde çözülecektir.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        break;
                    default:
                        mvcErrorModel.Message = $"Üzgünüz, işleminiz sırasında beklenmedik hata oluştu. En kısa süre içerisinde çözülecektir."
                        break;
                }

                var result = new ViewResult { ViewName = "Error" };
                result.StatusCode = 500;
                result.ViewData = new ViewDataDictionary(_metadataProvider, context.ModelState);
                result.ViewData.Add("MvcErrorModel", mvcErrorModel);
                context.Result = result;
            }
        }
    }
}
