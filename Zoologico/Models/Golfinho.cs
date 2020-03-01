using Zoologico.Interfaces;


namespace Zoologico.Models.Animais
{
    public class Golfinho : Animal, IAquario
    {
        public string Peixe()
        {
            return this.GetType().Name + "Sobrevive a águas salgadas";
        }
    }
}