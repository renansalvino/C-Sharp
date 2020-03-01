using System;
using EscolaDeRock.Interfaces;
namespace EscolaDeRock.Models
{
    public class Teclado :  InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Tocando acordes do piano");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando Solo o Piano");
            return true;
        }

       
}
}