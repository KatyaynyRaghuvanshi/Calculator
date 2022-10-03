namespace MathLibrary
{
    public class SubtractOperation : BinaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return operands[0] - operands[1];
        }
    }
}