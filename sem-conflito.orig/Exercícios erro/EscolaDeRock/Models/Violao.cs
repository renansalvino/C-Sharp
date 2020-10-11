using EscolaDeRock.Interfaces;


namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violão.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocar violao solo");
            return true;
        }

    }
}