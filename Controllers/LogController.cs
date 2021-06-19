using KissLog;
using Microsoft.AspNetCore.Mvc;
using System;

namespace SavingLogs.Controllers
{
    [ApiController]
    [Route("api")]
    public class LogController : ControllerBase
    {
        private readonly ILogger _logger;

        public LogController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpGet("trace")]
        public void Trace()
        {
            _logger.Trace("Trace Here");
        }

        [HttpGet("debug")]
        public void Debug()
        {
            _logger.Debug("Debug Here");
        }

        [HttpGet("warn")]
        public void Warn()
        {
            _logger.Warn("Warn Here");
        }

        [HttpGet("error")]
        public void Error()
        {
            _logger.Error("Error Here");
        }

        [HttpGet("exception")]
        public void Exception()
        {
            try
            {
                throw new Exception("Exception Here");
            }
            catch(Exception e)
            {
                _logger.Error(e);
            }
            
        }

        [HttpGet("exception-with-stack-trace")]
        public void ExceptionWithStackTrace()
        {
            throw new Exception("Exception Here");

        }

    }
}
