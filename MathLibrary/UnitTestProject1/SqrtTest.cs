using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class SqrtTest : SquareRootOperation
    {
        [TestMethod]
        public void TestSqrt()
        {
            double[] a = { 25 };
            double expres = 5;
            double result = 0;
            SqrtTest sqrtTest = new SqrtTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = sqrtTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
        [TestMethod]
        public void TestSqrt1()
        {
            double[] a = { 121 };
            double expres = 11;
            double result = 0;
            SqrtTest sqrtTest1 = new SqrtTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = sqrtTest1.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
    }
}
