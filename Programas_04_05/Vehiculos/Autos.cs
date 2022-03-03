using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas_04_05.Vehiculos
{
    public class Autos : AlmacenGral
    {
        public Autos(string aKey, dynamic aValue) 
        {
            this.Key = aKey;
            this.Value = aValue;
        }
       
        public void ShowData()
        {
            Console.WriteLine("La marca del auto es: {0}", Key);
            Console.WriteLine("El costo es: {0}", Value);
            Console.WriteLine("...................................");
        }

        public void ShowValue()
        {
            Console.WriteLine($"El valor del auto buscado {Key} es: {Value} ");
            Console.WriteLine("...................................");

        }


    }
}
