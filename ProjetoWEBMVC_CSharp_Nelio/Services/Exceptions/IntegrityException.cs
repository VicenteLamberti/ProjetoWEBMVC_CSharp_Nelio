using System;


namespace ProjetoWEBMVC_CSharp_Nelio.Services.Exceptions
{
    public class IntegrityException:ApplicationException
    {
        public IntegrityException(string message):base(message)
        {

        }
    }
}
