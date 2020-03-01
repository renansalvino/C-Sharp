using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo  : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do contra baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando Acordes do contrabaixo");
            return true;
        }
    }
    
    
        
}