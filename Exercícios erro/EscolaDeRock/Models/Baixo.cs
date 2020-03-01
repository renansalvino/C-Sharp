
using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    public class Baixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Biaxo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando Acordes do baixo");
            return true;
        }
    }
}