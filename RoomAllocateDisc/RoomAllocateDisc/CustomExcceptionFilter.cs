using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;  
using System.Net.Http;  
using System.Web.Http.Filters;  
  

namespace RoomAllocateDisc
{
    public class CustomExcceptionFilter:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;

            String message = String.Empty;

            var exceptionType = actionExecutedContext.Exception.GetType();
            if (exceptionType == typeof(ArgumentNullException))
            {
                message = "Null values are passed";
                status = HttpStatusCode.Conflict;
            }
            actionExecutedContext.Response = new HttpResponseMessage()

            {

                // Content = new StringContent(message, System.Text.Encoding.UTF8, "text/plain"),
                // Content = new StringContent(string.Format(message)),
                Content = new StringContent(actionExecutedContext.Exception.Message),
                ReasonPhrase = message,


                StatusCode = status

            };

            base.OnException(actionExecutedContext);
        }
}
}