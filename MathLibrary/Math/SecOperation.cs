using System;

namespace MathLibrary
{
    public class SecantOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            double result = 1 / Math.Cos(operands[0]);
            if (result == 0)
            {
                throw new DivideByZeroException("DivideByZero");
            }
            return result;
        }
    }
}