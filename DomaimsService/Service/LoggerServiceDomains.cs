using Domain.Model;
using Domain.Service;
using Infro.InfroService;
using Infro.Model;
using DomaimsService.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaimsService.Service
{
    public class LoggerServiceDomains : ILoggerDomains
    {
        private readonly ILogger _log;

        public LoggerServiceDomains(ILogger log)
        {
            _log = log;
        }
  
        public void Log(LoggerDomain log)
        {
            _log.RequestInformation(new Logger()
            {
                AddressIP = log.AddressIP,
                Controller = log.Controller,
                Request = log.Request
            });

        }
    }
}
