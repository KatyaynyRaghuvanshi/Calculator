namespace MathLibrary
{
    public interface IOperation
    {
        int OperandCount { get; }
        double Evaluate(double[] operands);
    }
}