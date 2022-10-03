using System;

namespace MathLibrary
{
    public class CotOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            double result = 1 / Math.Tan(operands[0]);
            if (result == 0)
            {
                throw new DivideByZeroException("DivideByZero");
            }
            return result;
        }
    }
}