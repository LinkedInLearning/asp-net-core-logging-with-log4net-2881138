using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace log4net.webapi.Extensions
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureBuildInExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    var contextRequest = context.Features.Get<IHttpRequestFeature>();

                    if (contextFeature != null)
                    {
                        string _error = $"[{context.Response.StatusCode}] - {contextFeature.Error.Message}: {contextRequest.Path}";

                        await context.Response.WriteAsync(_error);
                    }
                });
            });
        }
    }
}
