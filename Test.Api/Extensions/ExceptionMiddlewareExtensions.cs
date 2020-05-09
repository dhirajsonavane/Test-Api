using Microsoft.AspNetCore.Builder;

namespace Test.Api.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware.ExceptionMiddleware>();
        }
    }
}
