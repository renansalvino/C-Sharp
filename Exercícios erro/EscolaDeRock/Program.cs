using System;
using EscolaDeRock.Models;
using System.Collections.Generic;
namespace EscolaDeRock
{
    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentoMusical : int
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLÃO
    };

    enum CategoriaEnum: int 
    {
        RITMO,
        HARMONIA,
        MELODIA,
        PERCUSSÃO
    };

    }


    class Program
    {
        static void Main(string[] args)
        {
           String[]itensMenuprincipal = Enum.GetNames(typeof(FormacaoEnum));
           String[]itensMenuCatergoria = Enum.GetNames(typeof(CategoriaEnum));
        }
    }
}
