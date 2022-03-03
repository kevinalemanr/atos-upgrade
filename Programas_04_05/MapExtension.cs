using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programas_04_05.Vehiculos;


namespace Programas_04_05
{
    public static class MapExtension 
    {
         
        public static void GetFirstValue<T>(this Map<T> map) where T: AlmacenGral
        {

            string Key = map[0].Key.ToString();
            dynamic Value = map[0].Value;
                      
            Console.WriteLine($"El primer valor del arreglo es {Key} , {Value}");

        }

    }
}
