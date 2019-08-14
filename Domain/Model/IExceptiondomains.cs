using Domain.Service;


namespace Domain.Model
{
    public interface IExceptionDomains
    {
        void ExceptionLog(ExceptionDomains exceptionDomains);
    }
}
