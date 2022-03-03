using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programas_04_05
{
    public class Map<T> where T : AlmacenGral
    {
        private T[] almacenVehiculos;

        public Map(int z)
        {
            almacenVehiculos = new T[z];
        }

        public T this[int i]
        {
            get { return almacenVehiculos[i]; }
            set { almacenVehiculos[i] = value; }
        
        }

        public int this[string model] => SearchByModel(model);

        private int SearchByModel(string model)
        {
            for (int i = 0; i < almacenVehiculos.Length; i++)
            {
                if (almacenVehiculos[i].Key == model)
                {
                    return i;
                }

            }
            throw new ArgumentOutOfRangeException($"El modelo {model} no esta en la lista");
            
        }




    }
}
