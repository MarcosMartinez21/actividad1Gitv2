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

        public string GetNombre()
        {
            return _nombre;
        }

        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }

        public int GetEdad()
        {
            return _edad;
        }

        public void SetEdad(int edad)
        {
            _edad = edad;
        }
    }
}
