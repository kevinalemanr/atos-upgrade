using System;

namespace Programa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var objAnonimo = new { name = "Kevin", age = 28 };
            dynamic dynamicVar;


            Console.WriteLine("El nombre del tipo anonimo es: " + objAnonimo.name.ToString());
            Console.WriteLine("La edad del tipo anonimo es: {0}", objAnonimo.age);

            dynamicVar = 5;

            Console.WriteLine("El valor de la variable dinamica es:{0}", dynamicVar);

            dynamicVar = "Variable dinamica en accion";

            Console.WriteLine(dynamicVar);

            dynamicVar = new { namedv = "Jose", agedv = 28, actualDate = DateTime.Now };

            Console.WriteLine($"El nombre en la variable dinamica es {dynamicVar.namedv} , la edad es {dynamicVar.agedv}, la fecha es {dynamicVar.actualDate}");
        }
    }
}
