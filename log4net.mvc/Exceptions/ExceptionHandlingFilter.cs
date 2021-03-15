using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace log4net.mvc.Exceptions
{
    public class ExceptionHandlingFilter:ExceptionFilterAttribute
    {
        private readonly ILogger<ExceptionHandlingFilter> _logger;
        public ExceptionHandlingFilter()
        {
            var loggerFactory = new LoggerFactory();
            _logger = loggerFactory.CreateLogger<ExceptionHandlingFilter>();
        }

        public override void OnException(ExceptionContext context)
        {
            _logger.LogError($"OnException() - {context.Exception.Message}");
            context.ExceptionHandled = true;
        }
    }
}
