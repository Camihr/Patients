using Patients.Api.DTOs;
using Patients.Api.Exceptions;
using System.Net;
using System.Text.Json;

namespace Patients.Api.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _request;

        public ErrorHandlerMiddleware(RequestDelegate request)
        {
            _request = request;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _request(context);
            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ResponseModel<object>() { Exception = ex?.Message };

                switch (ex)
                {
                    case ApiException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        responseModel.Message = "Ha ocurrido un error inesperado";
                        break;
                    case KeyNotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.Message = "El recurso no fue encontrado";
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.Message = "Ha ocurrido un error inesperado";
                        break;
                }

                var result = JsonSerializer.Serialize(responseModel);
                await response.WriteAsJsonAsync(result);
            }
        }
    }
}
