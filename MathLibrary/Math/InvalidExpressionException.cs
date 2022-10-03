using System;
namespace MathLibrary
{
    public class InvalidExpressionException : Exception
    {
        public InvalidExpressionException(string message) : base(message)
        {
        }
    }
}