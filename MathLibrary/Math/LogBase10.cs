using System;

namespace MathLibrary
{
    public class LogBase10 : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Log10(operands[0]);
        }
    }
}