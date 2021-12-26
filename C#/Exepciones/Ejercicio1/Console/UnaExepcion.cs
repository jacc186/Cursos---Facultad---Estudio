using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class UnaExepcion : Exception
    {
        public UnaExepcion(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
