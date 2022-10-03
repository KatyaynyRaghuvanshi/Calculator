using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class MultiplyTest : MultiplyOperation
    {
        [TestMethod]
        public void TestMul()
        {
            double[] a = { 20, 2 };
            double expres = 40;
            double result = 0;
            MultiplyTest mulTest = new MultiplyTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = mulTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }

        [TestMethod]
        public void TestMul1()
        {
            double[] a = { 0, 2 };
            double expres = 0;
            double result = 0;
            MultiplyTest mulTest1 = new MultiplyTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = mulTest1.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
    }
}
