using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad1Gitv2
{
    public class Producto
    {
        private string _nombre;
        private double _precio;

        public Producto(string nombre, double precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public string MostrarDatos()
        {
            return ($"Nombre:{_nombre} \n" +
                $"Precio: {_precio}");
        }
    }
}
