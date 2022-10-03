namespace MathLibrary
{
    public class MultiplyOperation : BinaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return operands[0] * operands[1];
        }
    }
}