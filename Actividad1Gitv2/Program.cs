using System;

namespace Actividad1Gitv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Carlos", 16);

            persona.SetEdad(20);
            persona.SetNombre("Marcos");
        }
    }
}
