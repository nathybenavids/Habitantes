using System.Collections.Generic;
using System;

namespace Semana_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais pais1 = new ();

            pais1.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Galapagos";
            var provincia2 = new Provincia();
            provincia2.Nombre = "Chimborazo";

            provincia1.Cantones = new List<Canton>();
            var canton1 = new Canton();
            canton1.Nombre = "Quito";
            var canton2 = new Canton();
            canton2.Nombre = "Rumiñahui";

            canton1.Parroquias = new List<Parroquia>();
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "Alangasi";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Sangolqui";

            pais1.Provincias.Add(provincia1);
            pais1.Provincias.Add(provincia2);

            Console.WriteLine(pais1.ObtenerNumeroDeHabitantes());

        }
    }
}
