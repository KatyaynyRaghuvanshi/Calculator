using System;
namespace MathLibrary
{
    public class LogOperation : UnaryOperation
    {
        protected override double EvaluateValue(double[] operands)
        {
            return Math.Log(operands[0]);
        }
    }
}