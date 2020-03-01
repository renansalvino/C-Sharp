using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Orangotango : Animal, ICasaArvore
    {
        public string SubirArvores()
        {
            return this.GetType().Name + "Consegue subir em árvores";
        }
    }
}