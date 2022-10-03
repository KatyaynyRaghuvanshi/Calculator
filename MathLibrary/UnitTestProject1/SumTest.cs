using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class SumTest : AddOperation
    {
        [TestMethod]
        public void TestSum()
        {
            double[] a = { 2.0, 7 };
            double expres = 9;
            double result = 0;
            SumTest sumTest = new SumTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = sumTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
        [TestMethod]
        public void TestSum1()
        {
            double[] b = { 12, 8 };
            double express = 20;
            double results = 0;
            SumTest sumTest1 = new SumTest();

            for (int i = 0; i < b.Length; i++)
            {
                results = sumTest1.EvaluateValue(b);
            }
            Assert.AreEqual(express, results);

        }
    }
}
