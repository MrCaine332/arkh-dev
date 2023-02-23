using System.Net;
using System.Net.Mime;
using ComponentsWebLibraryAPI.Exceptions;
using Newtonsoft.Json;

namespace ComponentsWebLibraryAPI.middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ApiError ex)
            {
                await ReturnException(context.Response, ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                await ReturnException(context.Response, HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }

        private Task ReturnException(HttpResponse response, HttpStatusCode code, string message)
        {
            response.ContentType = MediaTypeNames.Application.Json;
            response.StatusCode = (int)code;
            
            return response.WriteAsync(JsonConvert.SerializeObject(message));
        }
    }
}
