using System;

namespace MathLibrary
{
    public class CosecOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            double result = 1 / Math.Sin(operands[0]);
            if (result == 0) throw new DivideByZeroException("DivideByZero");
            return 1 / result;
        }
    }
}