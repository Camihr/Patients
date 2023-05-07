using Patients.Api.Middlewares;

namespace Patients.Api.Extensions
{
    public static class ErrorHandler
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
