namespace PracticaGit_Arnau_Payes
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Persona persona = new Persona("Arnau Payès Playà");
            Salutador salutador = new Salutador();

            salutador.Saluda(persona);
        }
    }
}
