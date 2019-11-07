using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Pinguim : Animal, IPiscinaGelada
    {
        public string ResisteAoFrio()
        {
            return this.GetType().Name + "Resiste a águas geladas";
        }
    }
}