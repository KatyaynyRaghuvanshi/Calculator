using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class DivideTest : DivideOperation
    {
        [TestMethod]
        public void TestDiv()
        {
            double[] a = { 20.0, 2.0 };
            double expres = 10.0;
            double result = 0;
            DivideTest divTest = new DivideTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = divTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
        [TestMethod]
        public void TestDiv1()
        {
            double[] a = { 64, 4 };
            double expres = 16;
            double result = 0;
            DivideTest divTest1 = new DivideTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = divTest1.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
    }
}
