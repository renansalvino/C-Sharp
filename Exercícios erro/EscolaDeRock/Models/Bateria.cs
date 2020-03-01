using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo da bateria");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando Acordes");
            return true;
        }
    }
    
        
    }
