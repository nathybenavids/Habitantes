using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_2
{
    class Provincia
    {
        public int ProvinciaId
        {
            get; set;
        }
        public string Nombre
        {
            get; set;
        }

        public List<Canton> Cantones
        {
            get; set;
        } = new List<Canton>();
        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Canton actual in Cantones)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }

    }


}
