using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(ITextToPrint texttoprint)
        {
            File.WriteAllText("Recipe.txt", texttoprint.GetTextToPrint());
        }
    }
}