using System.Collections.Generic;

namespace Semana_2
{
    class Provincia
    {
        public int ProvinciaId {get; set; }
        public string Nombre {get; set; }

        public List<Canton> Cantones {get; set; } 
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
