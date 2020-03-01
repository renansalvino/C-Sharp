using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Tartaruga : Animal, IPiscina
    {
        public string  RespirarNaAgua()
        {
            return this.GetType().Name + "Consegue respirar na água";
        }
        

        
    }
}