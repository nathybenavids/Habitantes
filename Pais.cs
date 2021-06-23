using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2
{
    class Pais
    {
        public int PaisId
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

        public List<Provincia> Provincias
        {
            get; set;
        } = new List<Provincia>();

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;

            foreach (Provincia actual in Provincias)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}