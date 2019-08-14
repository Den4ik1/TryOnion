using Domain.Model;
using Domain.Service;
using Infro.InfroService;
using Infro.Model;
using System;

namespace DomaimsService.Service
{
    public class ExceptionServiceDomains : IExceptionDomains
    {
        private readonly IException _excep;

        public ExceptionServiceDomains(IException excep)
        {
            _excep = excep;
        }

        public void ExceptionLog(ExceptionDomains exc)
        {
            _excep.ExceptionInformation(new ExceptionLog()
            {
                ExceptionCode = exc.ExceptionCode,
                MasseageException = exc.MasseageException
            });
        }

       
    }
}
