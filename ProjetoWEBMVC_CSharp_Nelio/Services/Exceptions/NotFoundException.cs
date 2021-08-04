using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWEBMVC_CSharp_Nelio.Services.Exceptions
{
    public class NotFoundException:ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
