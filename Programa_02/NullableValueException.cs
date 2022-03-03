using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_02
{ 
    public class NullableValueException : NullReferenceException
    {
       public NullableValueException(string messageException) : base(messageException)
        {

                Console.WriteLine(messageException);

        }

    }

}
