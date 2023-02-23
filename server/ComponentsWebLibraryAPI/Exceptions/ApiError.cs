using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ComponentsWebLibraryAPI.Exceptions;

public class ApiError : Exception
{
    public readonly HttpStatusCode StatusCode;
    
    private ApiError(HttpStatusCode statusCode, string message)
        : base(message)
    {
        StatusCode = statusCode;
    }

    public static Exception BadRequest(string message)
    {
        return new ApiError(HttpStatusCode.BadRequest, message);
    }
    
    
}