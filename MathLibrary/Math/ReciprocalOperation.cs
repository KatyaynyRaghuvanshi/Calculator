using System;

namespace MathLibrary
{
    public class ReciprocalOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            if (operands[0] == 0) throw new DivideByZeroException("DivideByZero");
            return 1 / operands[0];
        }
    }
}