using Infro.InfroService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infro.Model
{
    public interface ILogger
    {
        void RequestInformation(Logger Request);
    }
}
