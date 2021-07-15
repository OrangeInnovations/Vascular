using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vascular.Exceptions
{
    public class PatientDomainException: Exception
    {
        public PatientDomainException()
        {

        }
        public PatientDomainException(string message): base(message)
        {

        }

        public PatientDomainException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
