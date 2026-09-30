using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1Gitv2
{
    public class Persona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string MostrarDatos()
        {
            return $"Nombre: {_nombre} \nEdad: {_edad}";
        }

        public bool esMayorEdad()
        {
            bool esMayor = false;
            if( _edad >= 18)
            {
                esMayor  = true;
            }
            return esMayor;
        }

    }
}
