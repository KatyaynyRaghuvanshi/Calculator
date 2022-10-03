using System;

namespace MathLibrary
{
    public class SquareRootOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Sqrt(operands[0]);
        }
    }
}