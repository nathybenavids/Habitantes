﻿using System.Collections.Generic;

namespace Semana_2
{
    class Canton
    {
        public int CantonId { get; set;}
        public string Nombre {get; set;}
        public List<Parroquia> Parroquias {get; set;} 
        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquias)
            {
                acumulador = acumulador + actual.Habitantes;
            }
            return acumulador;
        }
    }


}