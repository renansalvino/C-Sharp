using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Leao : Animal, IPasto
    {
        public string Correr()
        {
                return this.GetType().Name + "Consegue Correr";
        }
    }
}