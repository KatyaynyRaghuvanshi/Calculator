namespace MathLibrary
{
    public abstract class BinaryOperation : IOperation
    {

        public int OperandCount { get; }

        public BinaryOperation()
        {
            OperandCount = 2;
        }

        public double Evaluate(double[] operands)
        {
            if (operands.Length != OperandCount)
            {
                string message;
                if (operands.Length < OperandCount)
                {
                    message = "TooLessOperand";
                }
                else
                {
                    message = "TooManyOperand";
                }
                NumberOfOperandInOperationException exception = new NumberOfOperandInOperationException(message)
                {
                    Actual = operands.Length,
                    Expected = OperandCount
                };
                throw exception;
            }
            return EvaluateValue(operands);
        }
        protected abstract double EvaluateValue(double[] operands);
    }
}