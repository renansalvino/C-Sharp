using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Tucano : Animal
    {
        public string Voar()
        {
            return this.GetType().Name + "Consegue Voar";
        }
    }
}