using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using Test.Api.Models;
using Test.Api.Utilities;

namespace Test.Api.CustomAttributes
{
    public class ValidateRequestAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext actionContext)
        {
            var context = actionContext.HttpContext;

            if (!IsValidRequest(context.Request))
            {
                actionContext.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                actionContext.Result = new RedirectToRouteResult(new RouteValueDictionary
                {
                    {"controller", "RejectRequest"},
                    {"action", "Reject"}
                });
            }
            else
            {
                base.OnActionExecuting(actionContext);
            }
        }

        private bool IsValidRequest(HttpRequest request)
        {
            var requestUrl = RequestRawUrl(request);
            var config_x_api_key = string.Empty;
            try
            {
                config_x_api_key = Config.X_Api_Key;
            }
            catch (Exception)
            {
                return true;
            }

            try
            {
                var incoming_request_x_api_key = request.Headers[Constants.x_api_key].ToString();

                if (incoming_request_x_api_key != config_x_api_key)
                {
                    return false;
                }

                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        private static string RequestRawUrl(HttpRequest request)
        {
            return $"{request.Scheme}://{request.Host}{request.Path}{request.QueryString}";
        }

        private static IDictionary<string, string> ToDictionary(IFormCollection collection)
        {
            return collection.Keys
                .Select(key => new { Key = key, Value = collection[key] })
                .ToDictionary(k => k.Key, k => k.Value.ToString());
        }
    }
}
