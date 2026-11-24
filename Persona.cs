using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaGit_Arnau_Payes
{
    internal class Persona
    {
        public string Nom { get; set; }
        public int Edat { get; set; }

        public Persona(string nom, int edat)
        {
            Nom = nom;
            Edat = edat;
        }
    }
}
