using System;

namespace MathLibrary
{
    public class CosOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Cos(operands[0]);
        }
    }
}