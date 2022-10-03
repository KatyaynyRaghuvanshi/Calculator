namespace MathLibrary
{
    public class SquareOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return operands[0] * operands[0];
        }
    }
}