using System;

namespace MathLibrary
{
    public class DivideOperation : BinaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            if (operands[1] == 0) throw new DivideByZeroException("DivideByZero");
            return operands[0] / operands[1];
        }
    }
}