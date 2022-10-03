using System;
namespace MathLibrary
{
    public class NumberOfOperandInOperationException : Exception
    {
        public int Actual { get; set; }
        public int Expected { get; set; }
        public NumberOfOperandInOperationException(string message) : base(message)
        {
        }
    }
}