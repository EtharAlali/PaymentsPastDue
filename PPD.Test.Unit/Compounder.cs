using NUnit.Framework.Constraints;

namespace PPD.Test.Unit
{
    public class Compounder
    {
        private decimal Principle { get; set; }
        private double Apr { get; set; }

        public Compounder(decimal principle, double apr)
        {
            Principle = principle;
            Apr = apr;
        }

        public decimal PresentValueAt(int dayNumber)
        {
            return 0;
        }
    }
}