using System;
using Programas_04_05.Vehiculos;


namespace Programas_04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Map<Autos> vehiculo = new Map<Autos>(2);

            vehiculo[0] = new Autos("Escape", 200000); // Carga al objeto T con el set de indexer 
            vehiculo[1] = new Autos("Jetta", 21800);

            Autos unAuto = vehiculo[0];
            unAuto.ShowData(); // Ejecucion de indexer por valor entero, indice i en get

            vehiculo.GetFirstValue();

            int iBuscado = vehiculo["Escape"];
            Autos auBuscado = vehiculo[iBuscado];
            auBuscado.ShowValue(); // Ejecucion de indexer por string Key



            Map<Motos> automotor = new Map<Motos>(2);
            automotor[0] = new Motos("Yamaha", 50000);
            automotor[1] = new Motos("Italika", 20000);

            Motos unaMoto = automotor[0];
            unaMoto.ShowData();

            

            try
            {
                int mBuscada = automotor["Yakuza"];
                Motos motoBuscada = automotor[mBuscada];
                motoBuscada.ShowValue();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.WriteLine("Ha finalizado la ejecucion"); }


           
        }
    }
}
