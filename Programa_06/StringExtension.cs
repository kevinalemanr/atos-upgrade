using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programa_06
{
   public static class StringExtension
    {
        public static void ValidaTexto(this String s)
        {
            Regex rx = new Regex(@"(^[A-Z])([a-z]{3})\d{4}$");

            if (rx.IsMatch(s))
                Console.WriteLine("La cadena es valida");
            else
                Console.WriteLine("La cadena no es valida, el formato correcto es WwwwNNNN");

            MatchCollection matches = rx.Matches(s);

            Console.WriteLine("Se encontraron {0} coincidencias", matches.Count);


        }

    }
}
