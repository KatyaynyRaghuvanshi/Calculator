using System;
namespace MathLibrary
{
    internal class OutOfBoundMemoryIndex : Exception
    {
        public int Index { get; set; }
        public OutOfBoundMemoryIndex(string message) : base(message)
        {
        }
    }
}