using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class TubaraoMartelo : Animal
    {
        public string Peixe()
        {
            return this.GetType().Name + " Consegue respirar na água";
        }
    }
}