using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Arara : Animal, IGaiola
    {
        public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}