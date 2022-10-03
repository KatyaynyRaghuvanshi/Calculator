namespace MathLibrary
{
    internal class PercentOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] values)
        {
            double result = values[0] / 100;
            return result;
        }
    }
}