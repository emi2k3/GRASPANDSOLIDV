using System.Collections.Generic;
namespace Full_GRASP_And_SOLID
{
    public interface ITextToPrint
    {
        public IList<BaseStep> steps
        {
            get;
            set;
        }

        public Product FinalProduct { get; set; }

    public string GetTextToPrint()
        {
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (BaseStep step in this.steps)
            {
                result = result + step.GetTextToPrint() + "\n";
            }

            // Agregado por Expert
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
        }
    public double GetProductionCost()
        {
            double result = 0;

            foreach (BaseStep step in this.steps)
            {
                result = result + step.GetStepCost();
            }

            return result;
        }
    }
}