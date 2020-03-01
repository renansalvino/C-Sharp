using Zoologico.Interfaces;
namespace Zoologico.Models.Animais
{
    public class Chimpanze : Animal, ICasaArvore
    {
      public string SubirArvores()
      {
        return this.GetType().Name + " consegue Subir em árvores !";
      }
    }
}