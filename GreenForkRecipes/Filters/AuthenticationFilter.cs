using GreenForkRecipes.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenForkRecipes.Filters
{
    public class AuthenticationFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (AuthenticationService.LoggedUser == null)
            {
                context.HttpContext.Response.Redirect("/Auth/Login");
                context.Result = new EmptyResult();
            }
            base.OnActionExecuting(context);
        }
    }
}
