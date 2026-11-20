using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGit_Arnau_Payes
{
    internal class Salutador
    {
        public void Saluda(Persona p)
        {
            Console.WriteLine($"Hola, {p.Nom}!");
        }
    }
}
