using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomAuthorization
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomAuthorizeAttribute:AuthorizeAttribute
    {
        public string ViewName { get; set; }
        public CustomAuthorizeAttribute()
        {
            ViewName = "Authorize Failed";
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            IsUserAuthorized(filterContext);
        }
        void IsUserAuthorized(AuthorizationContext filterContext)
        {
            //user is authorised
            if (filterContext.Result == null)
                return;
            if(filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                ViewDataDictionary dic = new ViewDataDictionary();
                dic.Add("Message", "You don't have sufficient previliges to authorise this");
                var result = new ViewResult() { ViewName = this.ViewName, ViewData = dic };
                filterContext.Result = result;

            }
        }
    }
}

//[AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Method,
//Inherited = true, AllowMultiple = true)] 