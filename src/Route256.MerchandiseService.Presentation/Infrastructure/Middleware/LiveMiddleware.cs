﻿using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Route256.MerchandiseService.Presentation.Infrastructure.Middleware
{
    public class LiveMiddleware
    {
        public LiveMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.StatusCode = 200;
            await context.Response.WriteAsync(context.Response.StatusCode + " " +
                                              Enum.GetName(typeof(HttpStatusCode), context.Response.StatusCode));
        }
    }
}