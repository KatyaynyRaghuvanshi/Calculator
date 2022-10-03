namespace MathLibrary
{
    public class NegateOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            double result = -1 * operands[0];
            return result;
        }
    }
}