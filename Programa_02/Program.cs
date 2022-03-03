using System;

namespace Programa_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // int? nullable = null;
            int? nullable = 16;
            string valido;
                    

            try { string evaluateNull = nullable.HasValue ? valido = "Valor valido" : throw new NullableValueException("El valor de la variable es nulo");
                Console.WriteLine(valido);
            }
            catch (NullableValueException ex) { Console.WriteLine("Se ha producido la siguiente excepcion: " + ex.Message); }
            finally { Console.WriteLine("Finaliza la evaluacion del valor"); }

            


        }
    }
}
