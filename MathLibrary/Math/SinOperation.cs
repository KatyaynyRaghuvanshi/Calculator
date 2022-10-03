using System;

namespace MathLibrary
{
    public class SineOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Sin(operands[0]);
        }
    }
}