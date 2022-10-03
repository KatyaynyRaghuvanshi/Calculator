using MathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    [TestClass]
    public class ReciprocalTest : ReciprocalOperation
    {
        [TestMethod]
        public void TestRec()
        {
            double[] a = { 2.0 };
            double expres = 0.5;
            double result = 0;
            ReciprocalTest recTest = new ReciprocalTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = recTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
        [TestMethod]
        public void TestRec1()
        {
            double[] a = { 5 };
            double expres = 0.20;
            double result = 0;
            ReciprocalTest recTest = new ReciprocalTest();

            for (int i = 0; i < a.Length; i++)
            {
                result = recTest.EvaluateValue(a);
            }
            Assert.AreEqual(expres, result);

        }
    }
}
