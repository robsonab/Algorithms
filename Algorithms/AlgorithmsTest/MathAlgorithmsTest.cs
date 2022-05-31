using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class MathAlgorithmsTest
    {
        [TestMethod]
        public void SwapNumberTest()
        {
            var a = 10;
            var b = 20;

            MathAlgorithms.Swap(ref a, ref b);

            Assert.AreEqual(20, a);
            Assert.AreEqual(10, b);            
        }

        [TestMethod]
        public void FindMissingNumberTest()
        {            
            var array =new int[] {5,3,1,2 };

            var missingNum = MathAlgorithms.FindMissingNumber(array, array.Length);
            Assert.AreEqual(4, missingNum);
            missingNum = MathAlgorithms.FindMissingNumber(array);
            Assert.AreEqual(4, missingNum);

            array = new int[] { 4, 3, 1, 2, 6, 7, 8, 9, 10};
            missingNum = MathAlgorithms.FindMissingNumber(array, array.Length);
            Assert.AreEqual(5, missingNum);
            missingNum = MathAlgorithms.FindMissingNumber(array);
            Assert.AreEqual(5, missingNum);
        }
    }
}
