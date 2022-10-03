using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class SubTest : SubtractOperation
    {
        [TestMethod]
        public void TestSub()
        {
            double[] a = { 12, 7 };
            double expres = 5;
            double result = 0;
            SubTest subTest = new SubTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = subTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
        [TestMethod]
        public void TestSub1()
        {
            double[] b = { 10, 8 };
            double express = 2;
            double results = 0;
            SubTest subTest1 = new SubTest();

            for (int i = 0; i < b.Length; i++)
            {
                results = subTest1.EvaluateValue(b);
            }
            Assert.AreEqual(express, results);

        }
    }
}
