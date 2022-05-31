using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class MathAlgorithmsTest
    {
        [TestMethod]
        public void SwapNumberTest1()
        {
            var a = 10;
            var b = 20;

            Algorithms.MathAlgorithms.Swap(ref a, ref b);

            Assert.AreEqual(20, a);
            Assert.AreEqual(10, b);
            
        }
    }
}
