using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        //La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún en el equipo 
        //    y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
        public static bool operator +(Equipo e, Jugador j)
        {
           if(e.jugadores.Count < e.cantidadDeJugadores)//si los jugadores no superan el limite indicado
           {
                foreach (Jugador item in e.jugadores)
                {
                    if(item == j)
                    {
                       
                        return false;
                    }
                   
                }
                e.jugadores.Add(j);
                return true;
           }
           else
           {
                return false;
           }
        }

    }

    
}
