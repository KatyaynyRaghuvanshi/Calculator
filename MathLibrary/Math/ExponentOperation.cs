using System;

namespace MathLibrary
{
    internal class ExponentOperation : BinaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            double result = Math.Pow(operands[0], operands[1]);
            return result;
        }
    }
}