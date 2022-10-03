using System;

namespace MathLibrary
{
    public class TanOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Tan(operands[0]);
        }
    }
}